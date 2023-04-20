using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; //SQL kütüphanesi

namespace PROJECT_0
{
    public partial class KitapEkle : Form
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = KütüphaneOtomasyon.db;version=3;"); //database server yerine klasörde bir dosyada tutuluyor.bu satırla bağlıyoruz.
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            fancyAnasayfa.Instance.Enabled = true;
            fancyAnasayfa.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into Kitap(eklenmetarihi,kitapdurumu,adetsayisi,kitapadi,yazar,tur,sayfasayisi,basimyili,baskisayisi) values(@eklenmetarihi,@kitapdurumu,@adetsayisi,@kitapadi,@yazar,@tur,@sayfasayisi,@basimyili,@baskisayisi) ", connection);
    
            command.Parameters.AddWithValue("@eklenmetarihi", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@kitapdurumu", comboKitapDurum.Text);
            command.Parameters.AddWithValue("@adetsayisi", txtAdetSayi.Text);
            command.Parameters.AddWithValue("@kitapadi", txtKitapAd.Text);
            command.Parameters.AddWithValue("@yazar", txtYazar.Text);
            command.Parameters.AddWithValue("@tur", txtTur.Text);
            command.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayi.Text);
            command.Parameters.AddWithValue("@basimyili", txtBasimYil.Text);
            command.Parameters.AddWithValue("@baskisayisi", txtBaskiSayi.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap sisteme başarıyla eklendi.");
        }
    }
}
