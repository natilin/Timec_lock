using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timec_Clock.DAL;


namespace Timec_lock
{
    public partial class PasswordChangeForm : Form
    {
        FormHandler handler;
        public PasswordChangeForm(FormHandler handler)
        {
            this.handler = handler;
            InitializeComponent();
        }

        private void button_change_pwd_Click(object sender, EventArgs e)
        {
            string Tz = textBox_Tz.Text;
            string Old_pwd = textBox_old_pwd.Text;
            string new_pwd = textBox_new_pwd.Text;
            string pwd2 = textBox_confirm_pwd.Text;
            if (DBContext.AuthenticateUser(Tz, Old_pwd))
            {
                if (new_pwd == pwd2)
                {
                    string? ID = DBContext.GetEmployeeIdByNatId(Tz);
                    DBContext.ChangePassword(ID, new_pwd, Old_pwd);
                    clear_all();
                    MessageBox.Show("Password changed successfully");
                }
            }
            else { MessageBox.Show("The passwords are not the same"); }
        }
        private void clear_all()
        {
            try
            {
                foreach (Control txt in this.Controls)
                {

                    if (txt is TextBox)
                    {
                        txt.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel_Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            handler.ShowForm("LoginForm");
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
