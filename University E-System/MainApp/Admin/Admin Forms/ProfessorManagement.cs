using DGVPrinterHelper;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Drawing;
using System.Windows.Forms;
using University_E_System.MainApp;

namespace Login_SignUp.Admin_Forms
{
    public partial class ProfessorManagement : Form
    {
        public ProfessorManagement()
        {
            InitializeComponent();
        }



        private void ProfessorManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._University_E_SystemDataSet.Department);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this._University_E_SystemDataSet.Professor);
            professorBindingNavigator.Hide();
        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);

        }

        private void AddProf_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnDeleteProf_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnSubmitProfAdmin_Click(object sender, EventArgs e)
        {
            if (professorNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Name");
            }
            else if (e_MailTextBox.Text.Equals("") && e_MailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Enter a valid E-mail");
            }
            else if (passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a Password");
            }
            else
            {
                try
                {
                    professorBindingNavigatorSaveItem.PerformClick();
                }
                catch (System.Data.NoNullAllowedException)
                {
                    MessageBox.Show("Enter Faculty or Department");
                }
            }
        }

        private void PrintProf_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter
            {
                Title = "Professors Report",//Header 
                SubTitle = string.Format("Date: {0} ", DateTime.Today.ToShortDateString()),
                SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                PageNumbers = true,
                PageNumberInHeader = false,
                PorportionalColumns = true,
                HeaderCellAlignment = StringAlignment.Center,
                Footer = "KFS", //Footer 
                FooterSpacing = 15
            };
            printer.PrintDataGridView(professorDataGridView);

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            University_E_System.MainApp.Help h = new University_E_System.MainApp.Help();
            h.Show();
            
        }
    }
}
