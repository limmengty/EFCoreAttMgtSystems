using EFCoreAttMgtSystems.Entities;
using EFCoreAttMgtSystems.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreAttMgtSystems
{

    public partial class ClockManagement : Form
    {
        TimeSheet timeSheet;
        public ClockManagement(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
        }
        private void ShowMessage(string message, bool Issucceed)
        {
            if (Issucceed)
            {
                MessageBox.Show(message, "Application Infor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();
        }
        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new Log() { TimeStamp = DateTime.Now, TimeShift = 0 };
                timeSheet.LogEmployee(cardnoTextBox.Text, log);
                ShowMessage("Time-in Succssfully!", true);
            }
            catch (ArgumentException ex)
            {
                ShowMessage(ex.Message, false);
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new Log() { TimeStamp = DateTime.Now, TimeShift = 1 };
                timeSheet.LogEmployee(cardnoTextBox.Text, log);
                ShowMessage("Time-out Succssfully!", true);
            }
            catch (ArgumentException ex)
            {
                ShowMessage(ex.Message, false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cruuentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void cruuentTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClockManagement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
