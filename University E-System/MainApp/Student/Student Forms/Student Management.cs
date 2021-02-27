using DocumentFormat.OpenXml.Office2010.Excel;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace University_E_System.MainApp.Student.Student_Forms
{
    public partial class Student_Management : Form
    {
        private const string ConnectionString = "Server = DESKTOP-NESPLEP; Database = University E-System; Integrated Security = true; ";
        public Student_Management()
        {
            InitializeComponent();
        }



        private void Student_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            //this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);

            //MessageBox.Show(s.Showdata().ToString());

            /*DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(s.showdata());
            da.Fill(dt);*/


            //  TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(_University_E_SystemDataSet.Student);
            studentBindingNavigator.Hide();
        }

        private void StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);
        }


        private void btnEditStudentInfo_Click(object sender, EventArgs e)
        {  
            studentBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("Saved !");
        }

       
        private void Search_Click(object sender, EventArgs e)
        {

            SqlDataReader reader = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                  if (con.State == ConnectionState.Closed)
                      con.Open();
                    
             using (SqlCommand cmd = new SqlCommand("select * from Student where StudentID = @iD and Password =@PW", con))
                 {
                    cmd.Parameters.AddWithValue("@iD", studentIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@PW", passwordTextBox.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows && reader!= null)
                    {
                        reader.Close();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show(" Wrong ID or PW !");
                    }        
             }
                    
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help s = new Help();
            s.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StdHelp h = new StdHelp();
            h.Show();
        }
    }
}

