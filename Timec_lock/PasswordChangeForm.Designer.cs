namespace Timec_lock
{
    partial class PasswordChangeForm
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
            textBox_Tz = new TextBox();
            textBox_confirm_pwd = new TextBox();
            textBox_new_pwd = new TextBox();
            textBox_old_pwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_change_pwd = new Button();
            linkLabel_Cancel = new LinkLabel();
            SuspendLayout();
            // 
            // textBox_Tz
            // 
            textBox_Tz.Location = new Point(250, 67);
            textBox_Tz.Name = "textBox_Tz";
            textBox_Tz.Size = new Size(208, 31);
            textBox_Tz.TabIndex = 0;
            // 
            // textBox_confirm_pwd
            // 
            textBox_confirm_pwd.BackColor = Color.FromArgb(255, 224, 192);
            textBox_confirm_pwd.Location = new Point(250, 255);
            textBox_confirm_pwd.Name = "textBox_confirm_pwd";
            textBox_confirm_pwd.Size = new Size(208, 31);
            textBox_confirm_pwd.TabIndex = 1;
            textBox_confirm_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_new_pwd
            // 
            textBox_new_pwd.BackColor = Color.FromArgb(255, 224, 192);
            textBox_new_pwd.Location = new Point(250, 194);
            textBox_new_pwd.Name = "textBox_new_pwd";
            textBox_new_pwd.Size = new Size(208, 31);
            textBox_new_pwd.TabIndex = 2;
            textBox_new_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_old_pwd
            // 
            textBox_old_pwd.Location = new Point(250, 130);
            textBox_old_pwd.Name = "textBox_old_pwd";
            textBox_old_pwd.Size = new Size(208, 31);
            textBox_old_pwd.TabIndex = 3;
            textBox_old_pwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 70);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 4;
            label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 133);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 5;
            label2.Text = "סיסמא ישנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 197);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 6;
            label3.Text = "סיסמא חדשה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 258);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 7;
            label4.Text = "אישור סיסמא חדשה";
            // 
            // button_change_pwd
            // 
            button_change_pwd.BackColor = Color.FromArgb(255, 224, 192);
            button_change_pwd.Location = new Point(250, 328);
            button_change_pwd.Name = "button_change_pwd";
            button_change_pwd.Size = new Size(208, 43);
            button_change_pwd.TabIndex = 8;
            button_change_pwd.Text = "ביצוע החלפת סיסמא";
            button_change_pwd.UseVisualStyleBackColor = false;
            button_change_pwd.Click += button_change_pwd_Click;
            // 
            // linkLabel_Cancel
            // 
            linkLabel_Cancel.AutoSize = true;
            linkLabel_Cancel.Location = new Point(93, 337);
            linkLabel_Cancel.Name = "linkLabel_Cancel";
            linkLabel_Cancel.Size = new Size(54, 25);
            linkLabel_Cancel.TabIndex = 9;
            linkLabel_Cancel.TabStop = true;
            linkLabel_Cancel.Text = "ביטול";
            linkLabel_Cancel.LinkClicked += linkLabel_Cancel_LinkClicked;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(linkLabel_Cancel);
            Controls.Add(button_change_pwd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_old_pwd);
            Controls.Add(textBox_new_pwd);
            Controls.Add(textBox_confirm_pwd);
            Controls.Add(textBox_Tz);
            Name = "PasswordChangeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "שעון נוכחות -החלפת סיסמא";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Tz;
        private TextBox textBox_confirm_pwd;
        private TextBox textBox_new_pwd;
        private TextBox textBox_old_pwd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_change_pwd;
        private LinkLabel linkLabel_Cancel;
    }
}