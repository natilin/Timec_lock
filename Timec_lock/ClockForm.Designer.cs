namespace Timec_lock
{
    partial class ClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_emp_id = new Label();
            label_tz = new Label();
            label4 = new Label();
            label_last_enter = new Label();
            label6 = new Label();
            label_last_exit = new Label();
            button_Enter = new Button();
            button_Exit = new Button();
            linkLabel_cancel = new LinkLabel();
            SuspendLayout();
            // 
            // label_emp_id
            // 
            label_emp_id.AutoSize = true;
            label_emp_id.Location = new Point(161, 84);
            label_emp_id.Name = "label_emp_id";
            label_emp_id.Size = new Size(92, 25);
            label_emp_id.TabIndex = 1;
            label_emp_id.Text = "זהות עובד:";
            // 
            // label_tz
            // 
            label_tz.AutoSize = true;
            label_tz.ForeColor = Color.ForestGreen;
            label_tz.Location = new Point(288, 84);
            label_tz.Name = "label_tz";
            label_tz.Size = new Size(62, 25);
            label_tz.TabIndex = 2;
            label_tz.Text = "12345";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 215);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 3;
            label4.Text = "תאריך יציאה אחרון";
            // 
            // label_last_enter
            // 
            label_last_enter.AutoSize = true;
            label_last_enter.ForeColor = Color.ForestGreen;
            label_last_enter.Location = new Point(208, 162);
            label_last_enter.Name = "label_last_enter";
            label_last_enter.Size = new Size(59, 25);
            label_last_enter.TabIndex = 4;
            label_last_enter.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 122);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 5;
            label6.Text = "תאריך כניסה אחרון";
            // 
            // label_last_exit
            // 
            label_last_exit.AutoSize = true;
            label_last_exit.ForeColor = Color.Red;
            label_last_exit.Location = new Point(208, 274);
            label_last_exit.Name = "label_last_exit";
            label_last_exit.Size = new Size(59, 25);
            label_last_exit.TabIndex = 6;
            label_last_exit.Text = "label1";
            // 
            // button_Enter
            // 
            button_Enter.BackColor = Color.FromArgb(128, 255, 128);
            button_Enter.Location = new Point(26, 329);
            button_Enter.Name = "button_Enter";
            button_Enter.Size = new Size(91, 72);
            button_Enter.TabIndex = 7;
            button_Enter.Text = "כניסה";
            button_Enter.UseVisualStyleBackColor = false;
            button_Enter.Click += button_Enter_Click;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Red;
            button_Exit.Location = new Point(364, 329);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(91, 72);
            button_Exit.TabIndex = 8;
            button_Exit.Text = "יציאה";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Location = new Point(210, 336);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(54, 25);
            linkLabel_cancel.TabIndex = 9;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(linkLabel_cancel);
            Controls.Add(button_Exit);
            Controls.Add(button_Enter);
            Controls.Add(label_last_exit);
            Controls.Add(label6);
            Controls.Add(label_last_enter);
            Controls.Add(label4);
            Controls.Add(label_tz);
            Controls.Add(label_emp_id);
            Name = "ClockForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "שעון נוכחות - מסך ראשי";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_emp_id;
        private Label label_tz;
        private Label label4;
        private Label label_last_enter;
        private Label label6;
        private Label label_last_exit;
        private Button button_Enter;
        private Button button_Exit;
        private LinkLabel linkLabel_cancel;
    }
}