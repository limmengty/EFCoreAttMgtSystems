using EFCoreAttMgtSystems.Entities;
using EFCoreAttMgtSystems.Features;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAttMgtSystems
{
    public partial class EmployeeForm : Form
    {
        TimeSheet timeSheet;
        public EmployeeForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();
            saveButton.Enabled = false;
        }
        private void LoadToGrid()
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee();
            dataGridView1.Refresh();
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee(isSimpleVersion);
            dataGridView1.Refresh();
        }
        private void ClearAll()
        {
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            usernameTextBox.Clear();
            cardnoTextBox.Clear();
            passwordTextBox.Clear();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
        }

        //save even
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee()
                {
                    FullName = fullnameTextBox.Text.Trim(),
                    Position = positionTextBox.Text.Trim(),
                    CardNo = cardnoTextBox.Text.Trim(),
                    UserAccount = new UserAccount()
                    {
                        UserName = usernameTextBox.Text.Trim(),
                        Password = passwordTextBox.Text.Trim(),

                    }
                };
                timeSheet.AddEmployee(emp, cardnoTextBox.Text);
                ClearAll();
                LoadToGrid();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                addButton.Enabled = true;
                saveButton.Enabled = true;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                employeIdTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                useraccountIdTextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
                usernameTextBox.Text = dataGridView1.SelectedCells[5].Value.ToString();

                useraccountIdTextBox.Enabled = false;
                addButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you went to delete or not? ",
               "Employee Form",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
               ) == DialogResult.Yes)
                {
                    timeSheet.DeleteEmployee(employeIdTextBox.Text, useraccountIdTextBox.Text);
                }
                LoadToGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                employeIdTextBox.Clear(); ClearAll();
                addButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateEmployee(employeIdTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);

                LoadToGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                employeIdTextBox.Clear(); ClearAll();
                addButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
            }
        }
    }
}
