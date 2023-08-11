namespace EFCoreAttMgtSystems
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
            usernamelogTextBox = new TextBox();
            passwordsTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 141);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 27);
            label1.TabIndex = 5;
            label1.Text = "UserName: ";
            // 
            // usernamelogTextBox
            // 
            usernamelogTextBox.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelogTextBox.Location = new Point(190, 138);
            usernamelogTextBox.Margin = new Padding(5);
            usernamelogTextBox.Name = "usernamelogTextBox";
            usernamelogTextBox.Size = new Size(303, 33);
            usernamelogTextBox.TabIndex = 4;
            usernamelogTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordsTextBox
            // 
            passwordsTextBox.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordsTextBox.Location = new Point(190, 207);
            passwordsTextBox.Margin = new Padding(5);
            passwordsTextBox.Name = "passwordsTextBox";
            passwordsTextBox.Size = new Size(303, 33);
            passwordsTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 213);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 64);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 27);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(359, 285);
            loginButton.Margin = new Padding(0);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(134, 39);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 485);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(passwordsTextBox);
            Controls.Add(usernamelogTextBox);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernamelogTextBox;
        private TextBox passwordsTextBox;
        private Label label2;
        private Label label3;
        private Button loginButton;
    }
}