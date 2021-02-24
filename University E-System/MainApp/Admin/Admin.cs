using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using University_E_System;

namespace Login_SignUp.MainApp
{
    public partial class Admin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Admin()
        {
            InitializeComponent();
            random = new Random();
            btnBackHomeAdmin.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(Theme_Color.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Theme_Color.ColorList.Count);
            }
            tempIndex = index;
            string color = Theme_Color.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            DisableButton();
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe Print; 16.2pt; style=Bold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    btnBackHomeAdmin.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuAdmin.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe Print; 16.2pt; style=Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopAdmin.Controls.Add(childForm);
            this.panelDesktopAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentManagmentAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Forms.StudentManagement(), sender);
        }

        private void btnFacultyMangementAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Forms.FacultyManagement(), sender);
        }

        private void btnProfManagementAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Forms.ProfessorManagement(), sender);
        }

        private void btnBackHomeAdmin_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnBackHomeAdmin.Visible = false;
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseAdminForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMenuAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

