using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using University_E_System.MainApp.Professor.Professor_Forms;

namespace University_E_System
{
    public partial class ProfessorLogIn : Form
    {
        public ProfessorLogIn()
        {
            InitializeComponent();
        }


        private void BtnCloseLoginProfessor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnBackProfessorLogin_Click(object sender, EventArgs e)
        {
            Login_As logAs = new Login_As();
            logAs.Show();
            this.Hide();
        }


        private void ProfessorLogIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Professor' table. You can move, or remove it, as needed.
            //this.professorTableAdapter.Fill(this._University_E_SystemDataSet.Professor);
        }

        private void BtnLoginProfessor_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection("Server = DESKTOP-NESPLEP; Database = University E-System; Integrated Security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT E_Mail,Password FROM Professor WHERE E_Mail = @EMail AND Password = @PW", con);
            cmd.Parameters.AddWithValue("@EMail", e_MailTextBox.Text);
            cmd.Parameters.AddWithValue("@PW", passwordTextBox.Text);
            reader = cmd.ExecuteReader();
            if (reader != null && reader.HasRows)
            {
                MessageBox.Show("Welcome :D !");
                Professor p = new Professor();
                p.Show();
            }
            else { MessageBox.Show("Wrong Password or E-Mail!"); }
        }
    }
}
