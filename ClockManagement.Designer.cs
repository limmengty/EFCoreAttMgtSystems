namespace EFCoreAttMgtSystems
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            clockinButton = new Button();
            label1 = new Label();
            cruuentTimeLabel = new Label();
            clockoutButton = new Button();
            cardnoTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.42588F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.85005F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.29556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.42851F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(clockinButton, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(cruuentTimeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(clockoutButton, 3, 3);
            tableLayoutPanel1.Controls.Add(cardnoTextBox, 2, 2);
            tableLayoutPanel1.Location = new Point(60, 140);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.0004272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9995956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999847F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999994F));
            tableLayoutPanel1.Size = new Size(643, 376);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 4);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Open Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(637, 131);
            label2.TabIndex = 6;
            label2.Text = "Clock Form";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockinButton
            // 
            clockinButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clockinButton.Location = new Point(0, 336);
            clockinButton.Margin = new Padding(0);
            clockinButton.Name = "clockinButton";
            clockinButton.RightToLeft = RightToLeft.Yes;
            clockinButton.Size = new Size(135, 40);
            clockinButton.TabIndex = 4;
            clockinButton.Text = "Time In";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 243);
            label1.Name = "label1";
            label1.Size = new Size(246, 93);
            label1.TabIndex = 6;
            label1.Text = "Card No:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cruuentTimeLabel
            // 
            cruuentTimeLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cruuentTimeLabel, 4);
            cruuentTimeLabel.Dock = DockStyle.Fill;
            cruuentTimeLabel.Font = new Font("Open Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cruuentTimeLabel.Location = new Point(3, 131);
            cruuentTimeLabel.Name = "cruuentTimeLabel";
            cruuentTimeLabel.Size = new Size(637, 112);
            cruuentTimeLabel.TabIndex = 8;
            cruuentTimeLabel.Text = "Time";
            cruuentTimeLabel.TextAlign = ContentAlignment.TopCenter;
            cruuentTimeLabel.Click += cruuentTimeLabel_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            clockoutButton.Location = new Point(506, 336);
            clockoutButton.Margin = new Padding(0);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.RightToLeft = RightToLeft.Yes;
            clockoutButton.Size = new Size(137, 40);
            clockoutButton.TabIndex = 4;
            clockoutButton.Text = "Time Out";
            clockoutButton.UseVisualStyleBackColor = true;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Anchor = AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(cardnoTextBox, 2);
            cardnoTextBox.Location = new Point(255, 267);
            cardnoTextBox.Multiline = true;
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(385, 45);
            cardnoTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.53802967F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.82174F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.640232F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(751, 657);
            tableLayoutPanel2.TabIndex = 8;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint_1;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 657);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ClockManagement";
            Text = "ClockManagement";
            Load += ClockManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Button clockinButton;
        private Label label1;
        private TextBox cardnoTextBox;
        private Button clockoutButton;
        private Label cruuentTimeLabel;
    }
}