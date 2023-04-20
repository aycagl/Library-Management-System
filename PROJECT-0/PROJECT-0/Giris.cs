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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (txtUserName.Text == "admin" && txtpassword.Text == "1234")
           // {
                new fancylogin().Show();
                this.Hide();

           // }
           // else
           // {
            //    MessageBox.Show("Kullanıcı adı veya şifre hatalı.\n    Lütfen tekrar deneyiniz.");
          //      txtUserName.Clear();
           //     txtpassword.Clear();
          //      txtUserName.Focus();

          //  }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
