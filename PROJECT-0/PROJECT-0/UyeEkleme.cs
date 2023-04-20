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
    public partial class UyeEkleme : Form
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = KütüphaneOtomasyon.db;version=3;"); //database server yerine klasörde bir dosyada tutuluyor.bu satırla bağlıyoruz.

        public UyeEkleme()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            fancyAnasayfa.Instance.Enabled = true;
            fancyAnasayfa.Instance.BringToFront();

           

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into Uye(id,adsoyad,yas,cinsiyet,telefon,adres,email) values(@id,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email) ", connection);
            command.Parameters.AddWithValue("@id", txtTc.Text);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@yas", txtYas.Text);
            command.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Üye kaydı başarıyla gerçekleştirildi.");

           

        }

        private void UyeEkleme_Load(object sender, EventArgs e)
        {
       
            comboCinsiyet.SelectedIndex = 2;
        }
    }
}
