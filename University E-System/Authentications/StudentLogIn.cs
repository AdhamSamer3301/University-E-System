using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using University_E_System.MainApp.Student.Student_Forms;

namespace University_E_System
{
    public partial class StudentLogIn : Form
    {
        private const string ConnectionString = "Server = DESKTOP-NESPLEP; Database = University E-System; Integrated Security = true; ";

        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this._University_E_SystemDataSet.Student);
            studentBindingNavigator.Hide();
            SignUpPanel.Hide();
        }
        private void BtnGoSignUp_Click(object sender, EventArgs e)
        {
            SignUpPanel.Show();
            LoginPanel.Hide();
            try
            {
                bindingNavigatorAddNewItem.PerformClick();
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Don't Do this Again xD");
            }

        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SignUpPanel.Hide();
            LoginPanel.Show();
        }

        private void BtnBackLoginStudent_Click(object sender, EventArgs e)
        {
            Login_As logAS = new Login_As();
            logAS.Show();
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter your Name");
            }
            else if (e_MailTextBox1.Text.Equals("") && e_MailTextBox1.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid E-mail");
            }
            else if (phoneTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter your Phone No.");
            }
            else if (passwordTextBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter a Password");
            }
            else if (passwordTextBox1.TextLength < 8)
            {
                MessageBox.Show("Must be More than 8 characters ");
            }
            else
            {
                try
                {
                    studentBindingNavigatorSaveItem.PerformClick();
                    MessageBox.Show(" Welcome :D !");
                    Student s = new Student();
                    s.Show();
                }
                catch (System.Data.NoNullAllowedException)
                {
                    MessageBox.Show("Enter Faculty or Department");
                }
            }
        }

        private void StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT E_Mail,Password FROM Student WHERE E_Mail = @EMail AND Password = @PW", con);
                cmd.Parameters.AddWithValue("@EMail", e_MailTextBox.Text);
                cmd.Parameters.AddWithValue("@PW", passwordTextBox.Text);
                reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    //Showdata();
                    MessageBox.Show("Welcome :D !");
                    Student s = new Student();
                    s.Show();
                }
                else { MessageBox.Show("Wrong Password or E-Mail!"); }
            }

        }
        
        public int Showdata()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Student where E_mail = '" + e_MailTextBox.Text + "'";
            //cmd.ExecuteNonQuery();
            int iD = int.Parse(cmd.ExecuteScalar().ToString());
            MessageBox.Show(iD.ToString());
            return iD;
            //;
            //cmd.ExecuteScalar();
            //studentTableAdapter.Fill(grid);
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

