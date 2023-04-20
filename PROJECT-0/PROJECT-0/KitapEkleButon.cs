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
    public partial class KitapEkleButon : UserControl
    {
        public KitapEkleButon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEkle  kitapEkle = new KitapEkle();
            kitapEkle.Show();
            fancyAnasayfa.Instance.Enabled = false;
        }
    }
}
