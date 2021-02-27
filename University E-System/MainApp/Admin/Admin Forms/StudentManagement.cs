using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Windows.Forms;
using Login_SignUp.MainApp;
using University_E_System.MainApp;

namespace Login_SignUp.Admin_Forms
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }


        private void StudentManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._University_E_SystemDataSet.Student);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._University_E_SystemDataSet.Student);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);

            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._University_E_SystemDataSet.Student);

            studentBindingNavigator.Hide();
        }
        private void PPUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.* "
                };
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    PicBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);

        }

        private void BtnSubmitStdAdmin_Click(object sender, EventArgs e)
        {

            if (studentNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Name");
            }
            else if (e_MailTextBox.Text.Equals("") && e_MailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid E-mail");
            }
            else if (phoneTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Phone No.");
            }
            else if (passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Password");
            }
            else
            {
                try
                {
                    studentBindingNavigatorSaveItem.PerformClick();
                }
                catch (System.Data.NoNullAllowedException)
                {
                    MessageBox.Show("Enter Faculty or Department");
                }
            }


        }

        private void DelStd_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void AddStd_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void PrintStd_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter
            {
                Title = "Students Report",//Header 
                SubTitle = string.Format("Date: {0} ", DateTime.Today.ToShortDateString()),
                SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                PageNumbers = true,
                PageNumberInHeader = false,
                PorportionalColumns = true,
                HeaderCellAlignment = StringAlignment.Center,
                Footer = "KFS", //Footer 
                FooterSpacing = 15
            };
            printer.PrintDataGridView(studentDataGridView);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            University_E_System.MainApp.Help h = new University_E_System.MainApp.Help();
            h.Show();
        }
    }
}