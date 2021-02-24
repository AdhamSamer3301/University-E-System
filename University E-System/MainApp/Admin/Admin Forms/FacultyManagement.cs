using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login_SignUp.Admin_Forms
{
    public partial class FacultyManagement : Form
    {
        public FacultyManagement()
        {
            InitializeComponent();
        }



        private void FacultyManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this._University_E_SystemDataSet.Faculty);
            facultyBindingNavigator.Hide();
        }

        private void facultyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._University_E_SystemDataSet);

        }

        private void AddFac_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnDeleteFaculty_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnSubmitFacTAmin_Click(object sender, EventArgs e)
        {
            facultyBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("Saved !");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Faculties Report";//Header 
            printer.SubTitle = string.Format("Date: {0} ", DateTime.Today.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "KFS"; //Footer 
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(facultyDataGridView);
        }
    }
}
