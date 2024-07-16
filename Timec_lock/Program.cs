using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;
using Timec_Clock.DAL;
using Microsoft.Extensions.Configuration;

namespace Timec_lock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //var res = dB.MakeQuery("select * from Employees");
            FormHandler handler = new FormHandler();

            Application.Run();
        }
    }
}