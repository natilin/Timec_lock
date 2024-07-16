using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timec_lock
{
    public class FormHandler
    {
        Form logingform;
        public bool isNavigating= false;
        public FormHandler()
        {
            logingform = new LoginForm(this);
            logingform.Show();

        }
            private void CloseAllForms()
            {
                 isNavigating = true;
                List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
                foreach (Form item in openForms)
                {
                    item.Close();
                }
            isNavigating = false;
                //foreach (Form item in Application.OpenForms)
                //{
                //    item.Close();
                //}
            }

            public void ShowForm(string formName, string tz= null)
            {
                CloseAllForms();

                Form form = formName switch
                {
                    "LoginForm" => new LoginForm(this),
                    "ClockForm" => new ClockForm(this, tz),
                    "PasswordChangeForm" => new PasswordChangeForm(this),
                    _ => throw new ArgumentException("Invalid form name.", nameof(formName)),
                };
                form.Show();

            }
    }   
}
