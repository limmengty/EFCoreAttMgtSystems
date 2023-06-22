namespace EFCoreAttMgtSystems
{
    partial class MainForm
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
            label1 = new Label();
            timeRecordButton = new Button();
            manageeEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 86);
            label1.Name = "label1";
            label1.Size = new Size(326, 27);
            label1.TabIndex = 0;
            label1.Text = "Employee TimeSheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.Location = new Point(183, 156);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(326, 46);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // manageeEmployeeButton
            // 
            manageeEmployeeButton.Location = new Point(183, 246);
            manageeEmployeeButton.Name = "manageeEmployeeButton";
            manageeEmployeeButton.Size = new Size(326, 46);
            manageeEmployeeButton.TabIndex = 1;
            manageeEmployeeButton.Text = "Manage Employee";
            manageeEmployeeButton.UseVisualStyleBackColor = true;
            manageeEmployeeButton.Click += manageeEmployeeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 487);
            Controls.Add(manageeEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0, 9, 0, 9);
            Name = "Form1";
            Text = "MainForm";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button manageeEmployeeButton;
    }
}