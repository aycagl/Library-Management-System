using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PROJECT_0
{
    public partial class UyeListele : UserControl
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = KütüphaneOtomasyon.db;version=3;"); //database server yerine klasörde bir dosyada tutuluyor.bu satırla bağlıyoruz.
        DataSet daset = new DataSet();

        public static UyeListele _obj;
        public static UyeListele Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UyeListele();

                }
                return _obj;
            }
        }
        public void Guncelle()
        {
            
            daset.Reset(); //üye birden fazla kez listelenmesin diye.
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select * from Uye",connection);
            adtr.Fill(daset,"Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
            foreach(Control controls in this.Controls)
            {
                if (controls is TextBox)
                    (controls as TextBox).Clear();
            }
        }
        public UyeListele()
        {
            InitializeComponent();
        }

        private void UyeListele_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //datagrid seçilen satırın 1. değerini aldık.
            txtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYas.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kadın") comboCinsiyet.SelectedIndex = 0;   
            else if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek") comboCinsiyet.SelectedIndex = 1; 
            else if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Yok")  comboCinsiyet.SelectedIndex = 2;
            

            txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("update Uye set id = @id,adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email WHERE id = @id ", connection);
            command.Parameters.AddWithValue("@id", txtTc.Text);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@yas", txtYas.Text);
            command.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Üye güncelleme işlemi başarıyla gerçekleştirildi.");
            Guncelle();
        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Uye WHERE id = " + txtTc.Text, connection);
           
            
            DialogResult result = MessageBox.Show("Üye kaydını silmek istediğinizden emin misiniz?", "",  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Üye silme işlemi başarıyla gerçekleştirildi.");
            }

            
            connection.Close();
            Guncelle();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    new fancyAnasayfa().Show();
        //    fancyAnasayfa.Instance.Hide();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UyeListele_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                Guncelle();
            }
        }
    }
}
