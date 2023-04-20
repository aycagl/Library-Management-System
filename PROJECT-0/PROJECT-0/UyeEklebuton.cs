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
    public partial class UyeEklebuton : UserControl
    {
        public UyeEklebuton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkleme uyeEkleme = new UyeEkleme();
            uyeEkleme.Show();
            fancyAnasayfa.Instance.Enabled = false;
        }
    }
}
