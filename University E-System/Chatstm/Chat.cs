using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Chat : MaterialForm
    {
        //singleton pattern to create instance of main chat form (to make sure there is one instance of this form)

        private static Chat _instance;
        public static Chat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Chat();
                return _instance;
            }
        }
        public Chat()
        {
            InitializeComponent();

            // if something changed our things remain teh same
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        public Panel Content
        {
            get { return MainContainer; }
            set { MainContainer = value; }
        }
        private void Chat_Load(object sender, EventArgs e)
        {
            _instance = this;

            //add user login control
            MainContainer.Controls.Add(new ucLogin(){ Dock = DockStyle.Fill });
        }
    }
}
