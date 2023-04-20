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
    public partial class adminlogin : UserControl
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel2 = fancylogin.Instance.PnlContainer;
            panel2.Controls.Clear();
            uyeadminselect uas = new uyeadminselect();
            uas.Dock = DockStyle.Fill;
            panel2.Controls.Add(uas);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtpassword.Text == "1234")
            {
                new fancyAnasayfa().Show();
                fancylogin.Instance.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.\n    Lütfen tekrar deneyiniz.");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        private void adminlogin_Load(object sender, EventArgs e)
        {
            fancylogin.Instance.AcceptButton = button1;
            txtUserName.Focus();
        }
    }
}
