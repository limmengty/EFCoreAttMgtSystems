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

    public partial class LoginForm : Form
    {
        private TimeSheet _timeSheet;
        public LoginForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            usernameTextBox.Focus();
            _timeSheet = timeSheet;
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var un = usernameTextBox.Text.Trim();
            var ps = passwordTextBox.Text.Trim();
            Authentication auth = new Authentication(_timeSheet.DbContext, un, ps);
            try
            {
                bool result = auth.ValidateLogin();
                if (result) //Login Successfully
                {
                    this.Hide();//hide login form
                    MainForm mfrm = new MainForm(_timeSheet);
                    mfrm.Show();// Show main Form

                }
                else
                {
                    /*           usernameTextBox.Clear();*/
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();
                    MessageBox.Show("Incorrect username or password!!");
                }
            }
            catch (ArgumentException AE)
            {
                MessageBox.Show(AE.Message);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
