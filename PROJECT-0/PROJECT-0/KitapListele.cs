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
    public partial class KitapListele : UserControl
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = KütüphaneOtomasyon.db;version=3;"); //database server yerine klasörde bir dosyada tutuluyor.bu satırla bağlıyoruz.
        DataSet daset = new DataSet();

        private void Guncelle()
        {
            daset.Reset(); //üye birden fazla kez listelenmesin diye.
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select * from Kitap", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        public KitapListele()
        {
            InitializeComponent();
        }
       
        private void txtTcq_Click(object sender, EventArgs e)
        {

        }

        private void KitapListele_Load(object sender, EventArgs e)
        {
            Guncelle();
            comboKitapDurumu.SelectedIndex = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKitapID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //datagrid seçilen satırın 1. değerini aldık.
            txtEklenmeTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Var") comboKitapDurumu.SelectedIndex = 0;
            else if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Yok") comboKitapDurumu.SelectedIndex = 1;


            txtAdetSayisi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKitapAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTur.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSayfaSayisi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBaskiSayisi.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtBasimYili.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Kitap WHERE kitapid = " + txtKitapID.Text, connection);


            DialogResult result = MessageBox.Show("Kitap kaydını silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Kitap silme işlemi başarıyla gerçekleştirildi.");
            }


            connection.Close();
            Guncelle();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("update Kitap set kitapid = @kitapid,eklenmetarihi=@eklenmetarihi,kitapdurumu=@kitapdurumu,adetsayisi=@adetsayisi,kitapadi=@kitapadi,yazar=@yazar,tur=@tur,sayfasayisi=@sayfasayisi,baskisayisi=@baskisayisi,basimyili=@basimyili WHERE kitapid = @kitapid ", connection);
            command.Parameters.AddWithValue("@kitapid", txtKitapID.Text);
            command.Parameters.AddWithValue("@eklenmetarihi", txtEklenmeTarihi.Text);
            command.Parameters.AddWithValue("@kitapdurumu", comboKitapDurumu.Text);
            command.Parameters.AddWithValue("@adetsayisi", txtAdetSayisi.Text);
            command.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            command.Parameters.AddWithValue("@yazar", txtYazar.Text);
            command.Parameters.AddWithValue("@tur", txtTur.Text);
            command.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            command.Parameters.AddWithValue("@baskisayisi", txtBaskiSayisi.Text);
            command.Parameters.AddWithValue("@basimyili", txtBasimYili.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap güncelleme işlemi başarıyla gerçekleştirildi.");
            Guncelle();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where kitapadi like'%" + textBox1.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void KitapListele_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                Guncelle();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where yazar like'%" + textBox2.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }
    }
}
