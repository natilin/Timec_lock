using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timec_Clock.DAL;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timec_lock
{
    public partial class LoginForm : Form
    {
        FormHandler handler;
        public LoginForm(FormHandler handler)
        {
            this.handler = handler;
            InitializeComponent();
        }

        private void button_Change_Pass_Click(object sender, EventArgs e)
        {
            handler.ShowForm("PasswordChangeForm");
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string tz = textBox_Tz.Text;
            string pwd = textBox_Password.Text;
            if (DBContext.AuthenticateUser(tz, pwd))
            {
                handler.ShowForm("ClockForm", tz);
            }
            else
            {
                textBox_Tz.Clear();
                textBox_Password.Clear();
                string message = "Username or password is incorrect";
                MessageBox.Show(message);
                
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!handler.isNavigating)
            {
                Application.Exit();
            }
        }
    }
}
