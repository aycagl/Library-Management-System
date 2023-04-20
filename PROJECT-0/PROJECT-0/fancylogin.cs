using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_0
{
    public partial class fancylogin : Form
    {
        static fancylogin _obj;

        public static fancylogin Instance
        {
            get {
                if (_obj == null)
                {
                    _obj = new fancylogin();

                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }
        public fancylogin()
        {
            InitializeComponent();
        }


        private void uyebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fancylogin_Load(object sender, EventArgs e)
        {
            _obj = this;
            
            uyeadminselect uas = new uyeadminselect();
            uas.Dock = DockStyle.Fill;
            panel2.Controls.Add(uas);

        }
    }
}
