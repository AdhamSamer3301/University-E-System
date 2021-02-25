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

        private void listOnline_Click(object sender, EventArgs e)
        {
            frmSend fr = new frmSend();
            fr.Show();
        }
    }
}
