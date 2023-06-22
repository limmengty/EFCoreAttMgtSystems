using EFCoreAttMgtSystems.Features;

namespace EFCoreAttMgtSystems
{
    public partial class MainForm : Form
    {
        TimeSheet timeSheet;
        public MainForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
        }

        private void timeRecordButton_Click(object sender, EventArgs e)
        {
            ClockManagement form = new ClockManagement(timeSheet);
            form.ShowDialog();
        }

        private void manageeEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(timeSheet);
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit or no? ",
               "Employee TimeSheet Management",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
               ) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}