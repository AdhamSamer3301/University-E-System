using System;
using System.Windows.Forms;
using University_E_System.Authentications;

namespace University_E_System
{
    public partial class Login_As : Form
    {
        public Login_As()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogASStudent_Click(object sender, EventArgs e)
        {
            StudentLogIn f1 = new StudentLogIn();
            f1.Show();
            this.Hide();

        }

        private void btnLogASProfessor_Click(object sender, EventArgs e)
        {
            ProfessorLogIn ProfLogin = new ProfessorLogIn();
            ProfLogin.Show();
            this.Hide();
        }

        private void btnLogAsAdmin_Click(object sender, EventArgs e)
        {
            AdminLogIn Admin = new AdminLogIn();
            Admin.Show();
            this.Hide();
        }

        private void Login_As_Load(object sender, EventArgs e)
        {

        }
    }
}
