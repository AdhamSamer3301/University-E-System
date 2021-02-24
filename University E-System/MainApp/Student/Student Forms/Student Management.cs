using DocumentFormat.OpenXml.Office2010.Excel;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace University_E_System.MainApp.Student.Student_Forms
{
    public partial class Student_Management : Form
    {
        public Student_Management()
        {
            InitializeComponent();
        }



        private void Student_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            
            /*DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(s.showdata());
            da.Fill(dt);*/

            
            //  TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(_University_E_SystemDataSet.Student);


        }

        private void StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);
        }


        private void btnEditStudentInfo_Click(object sender, EventArgs e)
        {

            if (studentNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter your Name");
            }
            else if (e_MailTextBox.Text.Equals("") && e_MailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid E-mail");
            }
            else if (phoneTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter your Phone No.");
            }
            else if (passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Password");
            }
            else if (passwordTextBox.TextLength < 8)
            {
                MessageBox.Show("Must be More than 8 characters ");
            }
            else
            {
                try
                {
                    studentBindingNavigatorSaveItem.PerformClick();
                    MessageBox.Show("Saved !");
                }
                catch (System.Data.NoNullAllowedException)
                {
                    MessageBox.Show("Enter Faculty or Department");
                }
            }
        }

        private void PicUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.* "
                };
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PicBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
