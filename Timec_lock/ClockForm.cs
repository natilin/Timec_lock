using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timec_Clock.DAL;

namespace Timec_lock
{
    public partial class ClockForm : Form
    {
        FormHandler handler;
        private string TZ;
        private string ID;
        public ClockForm(FormHandler handler, string tz)
        {
            this.handler = handler;
            InitializeComponent();
            TZ = tz.Trim();
            label_tz.Text = tz;
            ID = DBContext.GetEmployeeIdByNatId(tz);
            initInformation();

        }
        private void initInformation()
        {
            var lastEntryTime = DBContext.GetEntryNExitTime(ID).Rows[0]["EntryTime"].ToString();

            if (lastEntryTime != "" || lastEntryTime != null)
            {
                label_last_enter.Text = lastEntryTime;
            }
            else { label_last_enter.Text = "00000"; }

            string? lastExitTime = DBContext.GetEntryNExitTime(ID).Rows[0]["ExitTime"].ToString();
            if (lastExitTime != "")
            {
                label_last_exit.Text = lastExitTime;
            }
            else { label_last_exit.Text = "00000"; }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            handler.ShowForm("LoginForm");
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string response = (string)DBContext.SetEntry(ID);
            switch (response)
            {
                case "invalid entry":
                    MessageBox.Show("invalid entry");
                    break;
                case "Entry update succesful":
                    MessageBox.Show("Entry update succesful");
                    break;
                default:
                    break;
            }
            initInformation();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            string response = (string)DBContext.SetExit(ID);
            switch (response)
            {
                case "invalid exit":
                    MessageBox.Show("invalid exit");
                    break;
                case "Exit update succesful":
                    MessageBox.Show("Exit update succesful");
                    break;
                default:
                    break;
            }
            initInformation();
        }
    }
}
