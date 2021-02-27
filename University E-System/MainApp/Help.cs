using System;
using System.Windows.Forms;

namespace University_E_System.MainApp
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_University_E_SystemDataSet._Fac___Dept' table. You can move, or remove it, as needed.
            this.fac___DeptTableAdapter.Fill(this._University_E_SystemDataSet._Fac___Dept);
            // TODO: This line of code loads data into the '_University_E_SystemDataSet._Fac___Dept' table. You can move, or remove it, as needed.
            this.fac___DeptTableAdapter.Fill(this._University_E_SystemDataSet._Fac___Dept);
        }
    }
}
