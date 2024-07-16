namespace Timec_lock
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            textBox_Tz = new TextBox();
            textBox_Password = new TextBox();
            button_Login = new Button();
            button_Change_Pass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 41);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "תעודת זהות ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 153);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "סיסמא";
            // 
            // textBox_Tz
            // 
            textBox_Tz.Location = new Point(138, 102);
            textBox_Tz.Name = "textBox_Tz";
            textBox_Tz.Size = new Size(240, 31);
            textBox_Tz.TabIndex = 2;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(138, 206);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(240, 31);
            textBox_Password.TabIndex = 3;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(138, 313);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(240, 49);
            button_Login.TabIndex = 4;
            button_Login.Text = "כניסה";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Change_Pass
            // 
            button_Change_Pass.Location = new Point(138, 429);
            button_Change_Pass.Name = "button_Change_Pass";
            button_Change_Pass.Size = new Size(240, 49);
            button_Change_Pass.TabIndex = 5;
            button_Change_Pass.Text = "החלפת סיסמא";
            button_Change_Pass.UseVisualStyleBackColor = true;
            button_Change_Pass.Click += button_Change_Pass_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 557);
            Controls.Add(button_Change_Pass);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Tz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "שעון נוכחות - מסך התחברות";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Tz;
        private TextBox textBox_Password;
        private Button button_Login;
        private Button button_Change_Pass;
    }
}