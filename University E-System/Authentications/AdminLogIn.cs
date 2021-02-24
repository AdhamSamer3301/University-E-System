using Login_SignUp.MainApp;
using System;
using System.Windows.Forms;

namespace University_E_System.Authentications
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void btnLogInAdmin_Click(object sender, EventArgs e)
        {
            if (txtBoxPasswordAdmin.Text == "1234")
            {
                Admin Amd = new Admin();
                Amd.Show();
            }
            else { MessageBox.Show("Wrong Password !!"); }
        }

        private void btnCloseLoginAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Login_As l = new Login_As();
            l.Show();
            this.Close();
        }
    }
}
