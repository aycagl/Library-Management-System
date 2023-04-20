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
    public partial class uyeadminselect : UserControl
    {
        public uyeadminselect()
        {
            InitializeComponent();
        }

        private void uyebtn_Click(object sender, EventArgs e)
        {
            Panel panel2 = fancylogin.Instance.PnlContainer; 
            panel2.Controls.Clear();
            uyelogin ue = new uyelogin();
            ue.Dock = DockStyle.Fill;
            panel2.Controls.Add(ue);
            
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            Panel panel2 = fancylogin.Instance.PnlContainer;
            panel2.Controls.Clear();
            adminlogin ae = new adminlogin();
            ae.Dock = DockStyle.Fill;
            panel2.Controls.Add(ae);
        }
    }
}
