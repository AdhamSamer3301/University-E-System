using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_E_System.Chatstm
{
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void ucMain_Load(object sender, EventArgs e)
        {
            professorIDListBox.Hide();
            studentIDListBox.Hide();
        }

        private void Professors_Click(object sender, EventArgs e)
        {
            studentIDListBox.Hide();
            professorIDListBox.Show();
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this._University_E_SystemDataSet.Professor);

        }

        private void Students_Click(object sender, EventArgs e)
        {
            professorIDListBox.Hide();
            studentIDListBox.Show();
            // TODO: This line of code loads data into the '_University_E_SystemDataSet.Professor' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._University_E_SystemDataSet.Student);
            
        }

        private void studentIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmSend s = new frmSend();
            s.Show();
        }

        private void professorIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmSend f = new frmSend();
            f.Show();
        }
    }
}
