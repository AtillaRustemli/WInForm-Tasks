namespace Task_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLabel = new Label();
            passwordLabel = new Label();
            email = new TextBox();
            password = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            emailLabel.ForeColor = Color.Snow;
            emailLabel.Location = new Point(92, 88);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(120, 37);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "E-Mail : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.Snow;
            passwordLabel.Location = new Point(92, 169);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(153, 37);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password :";
            passwordLabel.Click += label2_Click;
            // 
            // email
            // 
            email.Location = new Point(271, 104);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(468, 22);
            email.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(271, 183);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(468, 23);
            password.TabIndex = 4;
            // 
            // Enter
            // 
            Enter.BackColor = Color.DarkGray;
            Enter.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            Enter.ForeColor = SystemColors.ButtonHighlight;
            Enter.Location = new Point(250, 311);
            Enter.Name = "Enter";
            Enter.Size = new Size(303, 89);
            Enter.TabIndex = 5;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(984, 561);
            Controls.Add(Enter);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task-1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private Label passwordLabel;
        private TextBox email;
        private TextBox password;
        private Button Enter;
    }
}
