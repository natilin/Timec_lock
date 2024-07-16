using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Timec_Clock.DAL
{
    internal static class DBContext
    {
        private static readonly string connectionString = GetConnString();
        private static string? GetConnString()
        {
            IConfiguration builder = new ConfigurationBuilder()
              .AddJsonFile("secrets.json", optional: true) // Add secrets.json
              .Build();
            // Read a value from the configuration
            string connString = builder["ConnectionString"];
            if (connString == null)
            {
                throw new Exception("cannot read connection string");
            }
            return connString;
        }



        static public object MakeQuery(string queryStr,string type, SqlParameter[] parameters = null)
        {
            object output = new object();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        conn.Open();
                        
                            switch (type)
                            {
                                case "DataTable":
                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {
                                    output = new DataTable();
                                    adapter.Fill((DataTable)output);
                                    return output;
                                }
                                    

                                case "ExecuteScalar":
                                    output = cmd.ExecuteScalar().ToString();
                                    return output;
                                
                            }      
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An Error occurred: " + ex.Message);
                    }
                }
            }
            return output;
        }

        static private void MakeTransactionNonQuery(string query, SqlConnection connection, SqlParameter[] parameters = null, SqlTransaction transaction = null)
        {
            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
        }

        static public bool AuthenticateUser(string tz, string pwd)
        {
            string loginQuery = "SELECT e.ID FROM Passwords p INNER JOIN Employees e ON e.ID = p.EmployeeID WHERE EmployeeNat = @tz AND EmployeePassword = @pwd";
            SqlParameter[] parameters = {
                new SqlParameter("@tz", tz),
                new SqlParameter("@pwd", pwd)
            };
            DataTable dataTable = (DataTable)MakeQuery(loginQuery,"DataTable" ,parameters);
            return dataTable != null && dataTable.Rows.Count > 0;
        }

        static public void ChangePassword(string id, string newPwd, string oldPwd)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update the IsActive status of the old password
                        string updateOldPasswordQuery = "UPDATE Passwords SET IsActive = 0 WHERE EmployeeID = @id AND EmployeePassword = @oldPwd AND IsActive = 1";
                        SqlParameter[] updateOldPasswordParams = {
                            new SqlParameter("@id", id),
                            new SqlParameter("@oldPwd", oldPwd)
                        };
                        MakeTransactionNonQuery(updateOldPasswordQuery, connection, updateOldPasswordParams, transaction);

                        // Insert the new password
                        string insertNewPasswordQuery = "INSERT INTO Passwords(EmployeeID, EmployeePassword, IsActive) VALUES (@id, @newPwd, 1)";
                        SqlParameter[] insertNewPasswordParams = {
                            new SqlParameter("@id", id),
                            new SqlParameter("@newPwd", newPwd)
                        };
                        MakeTransactionNonQuery(insertNewPasswordQuery, connection, insertNewPasswordParams, transaction);

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of error
                        transaction.Rollback();
                        throw; // Rethrow the exception to be handled at a higher level
                    }
                }
            }
        }

        static public string? GetEmployeeIdByNatId(string natId)
        {
            string query = "SELECT ID FROM Employees WHERE EmployeeNat = @natId";
            SqlParameter[] parameters = {
                new SqlParameter("@natId", natId)
            };
            string result = (string)MakeQuery(query, "ExecuteScalar", parameters);
            return result;
        }
        static public DataTable? GetEntryNExitTime(string Id)
        {
            string query = "SELECT" +
                "(SELECT TOP(1) EntryTime " +
                "FROM [EmployeeAttendance] " +
                "WHERE EmployeeCode = @ID " +
                "ORDER BY EntryTime DESC) AS EntryTime,(select TOP(1) ExitTime " +
                "FROM [EmployeeAttendance] " +
                "WHERE EmployeeCode = @ID AND ExitTime IS NOT NULL " +
                "ORDER BY ExitTime DESC) AS ExitTime ";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", Id)
                };
            DataTable dataTable = (DataTable)MakeQuery(query, "DataTable",parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable;
            }
            return null;
        }
        static public string SetEntry(string Id)
        {
            string query = "DECLARE @answer VARCHAR(25) = 'invalid entry';\r\nDECLARE @LAST_EXIT DATETIME ;\r\n select @LAST_EXIT = ExitTime \r\n from EmployeeAttendance \r\n where EmployeeCode = @ID AND EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance WHERE EmployeeCode = @ID)\r\nIF @LAST_EXIT IS NOT NULL BEGIN INSERT INTO EmployeeAttendance(EmployeeCode,EntryTime) VALUES (@ID, GETDATE()) \r\nset @answer = 'Entry update succesful' \r\nend\r\n SELECT @answer";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", Id)
            };
            string answer = (string)MakeQuery(query, "ExecuteScalar", parameters);
            return answer;
        }
        static public string SetExit(string Id)
        {
            string query = "DECLARE @answer VARCHAR(25) = 'invalid exit';\r\nDECLARE @LAST_EXIT DATETIME;\r\n\r\nselect @LAST_EXIT = ExitTime\r\nfrom EmployeeAttendance\r\nwhere EmployeeCode = @ID AND EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance WHERE EmployeeCode = @ID)\r\n\r\nIF @LAST_EXIT IS NULL\r\n\r\nBEGIN\r\nUPDATE EmployeeAttendance\r\nSET ExitTime = GETDATE()\r\nWHERE EmployeeCode = @ID\r\nAND EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance WHERE EmployeeCode = @ID);\r\nset @answer = 'Exit update succesful'\r\n END \r\n SELECT @answer";
                
            SqlParameter[] parameters = {
                new SqlParameter("@ID", Id)
            };
            string answer = (string)MakeQuery(query, "ExecuteScalar", parameters);
            return answer;
        }
    }
}
