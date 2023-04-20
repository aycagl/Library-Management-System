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
    public partial class fancyAnasayfa : Form
    {
        public fancyAnasayfa()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(50, Color.White);
            panel4.BackColor = Color.FromArgb(75, Color.WhiteSmoke);
            panel5.BackColor = Color.FromArgb(75, Color.WhiteSmoke);

        }
        static fancyAnasayfa _obj;

        public static fancyAnasayfa Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new fancyAnasayfa();

                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel4; }
            set { panel4 = value; }
        }
        private void btnUye_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            UyeListele uyelist = new UyeListele();
            uyelist.Dock = DockStyle.Fill;
            panel4.Controls.Add(uyelist);

            UyeEklebuton uyeEklebuton = new UyeEklebuton();
            uyeEklebuton.Dock = DockStyle.Right;
            panel5.Controls.Add(uyeEklebuton);        
        }

        private void fancyAnasayfa_Load(object sender, EventArgs e)
        {

            _obj = this;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel5.Controls.Clear();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            KitapListele kitapList = new KitapListele();
            kitapList.Dock = DockStyle.Fill;
            panel4.Controls.Add(kitapList);

            KitapEkleButon kitapEkleButon = new KitapEkleButon();
            kitapEkleButon.Dock = DockStyle.Right;
            panel5.Controls.Add(kitapEkleButon);

        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel5.Controls.Clear();

            OduncKitap oduncKitap = new OduncKitap();
            oduncKitap.Dock = DockStyle.Fill;
            panel4.Controls.Add(oduncKitap);

            oduncbuton oduncbuton = new oduncbuton();
            oduncbuton.Dock = DockStyle.Right;
            panel5.Controls.Add(oduncbuton);

            IadeAlButton iadeAlButton = new IadeAlButton   ();
            iadeAlButton.Dock = DockStyle.Right;
            panel5.Controls.Add(iadeAlButton);


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
