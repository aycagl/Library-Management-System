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
    public partial class IadeAlButton : UserControl
    {
        public IadeAlButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IadeAl iadeAl = new IadeAl();
            iadeAl.Show();
            fancyAnasayfa.Instance.Enabled = false;
        }
    }
}
