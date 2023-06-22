namespace EFCoreAttMgtSystems
{
    partial class EmployeeForm
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
            addButton = new Button();
            saveButton = new Button();
            employeIdTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            deleteButton = new Button();
            label7 = new Label();
            useraccountIdTextBox = new TextBox();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(70, 564);
            addButton.Margin = new Padding(0);
            addButton.Name = "addButton";
            addButton.Size = new Size(130, 50);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(222, 564);
            saveButton.Margin = new Padding(0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(130, 50);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // employeIdTextBox
            // 
            employeIdTextBox.Location = new Point(222, 81);
            employeIdTextBox.Name = "employeIdTextBox";
            employeIdTextBox.Size = new Size(271, 33);
            employeIdTextBox.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(222, 142);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(271, 33);
            fullnameTextBox.TabIndex = 1;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(222, 212);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(271, 33);
            positionTextBox.TabIndex = 1;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(222, 288);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(271, 33);
            cardnoTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(208, 431);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(271, 33);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(208, 500);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(271, 33);
            passwordTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(522, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(815, 449);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 81);
            label1.Name = "label1";
            label1.Size = new Size(118, 27);
            label1.TabIndex = 3;
            label1.Text = "EmployeeId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 142);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 3;
            label2.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 212);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 3;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 288);
            label4.Name = "label4";
            label4.Size = new Size(80, 27);
            label4.TabIndex = 3;
            label4.Text = "CardNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 437);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 3;
            label5.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 506);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1207, 31);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(130, 50);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Detete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 366);
            label7.Name = "label7";
            label7.Size = new Size(143, 27);
            label7.TabIndex = 6;
            label7.Text = "UserAccountId";
            // 
            // useraccountIdTextBox
            // 
            useraccountIdTextBox.Location = new Point(208, 360);
            useraccountIdTextBox.Name = "useraccountIdTextBox";
            useraccountIdTextBox.Size = new Size(271, 33);
            useraccountIdTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(363, 564);
            updateButton.Margin = new Padding(0);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(130, 50);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 696);
            Controls.Add(updateButton);
            Controls.Add(label7);
            Controls.Add(useraccountIdTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(addButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(cardnoTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(fullnameTextBox);
            Controls.Add(employeIdTextBox);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button saveButton;
        private TextBox employeIdTextBox;
        private TextBox fullnameTextBox;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button deleteButton;
        private Label label7;
        private TextBox useraccountIdTextBox;
        private Button updateButton;
    }
}