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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            new UyeEkleme().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            new UyeListele().Show();
            this.Hide();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            new KitapEkle().Show();
            this.Hide();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            new KitapListele().Show();
            this.Hide();
        }
    }
}
