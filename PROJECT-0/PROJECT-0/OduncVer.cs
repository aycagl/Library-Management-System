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
    public partial class OduncVer : Form
    {

        SQLiteConnection connection = new SQLiteConnection(@"Data Source = KütüphaneOtomasyon.db;version=3;"); //database server yerine klasörde bir dosyada tutuluyor.bu satırla bağlıyoruz.
        int kitapid =0;
        public void UyeGuncelle()
        {
            DataSet daset = new DataSet();
            daset.Reset(); //üye birden fazla kez listelenmesin diye.
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select * from Uye", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
            //foreach (Control controls in this.Controls)
            //{
            //    if (controls is TextBox)
            //        (controls as TextBox).Clear();
            //}
        }
        public void KitapGuncelle()
        {
            DataSet daset = new DataSet();
            daset.Reset(); //kitap birden fazla kez listelenmesin diye.
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select * from Kitap", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView2.DataSource = daset.Tables["Kitap"];
            connection.Close();
            //foreach (Control controls in this.Controls)
            //{
            //    if (controls is TextBox)
            //        (controls as TextBox).Clear();
            //}
        }
        public OduncVer()
        {
            InitializeComponent();
        }


        // İlk yüklemede istenilen değişiklikleri gerçekleştirir
        private void OduncVer_Load(object sender, EventArgs e)
        {
            UyeGuncelle();
            KitapGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            connection.Open();
                SQLiteCommand uyechecker = new SQLiteCommand("select * from uye where id = @id", connection);
                
            SQLiteDataAdapter uyechecker = new SQLiteDataAdapter("select * from Uyew here id = @id", connection);
            uyechecker.Parameters.AddWithValue("@id", txttcno);
            MessageBox.Show(reader.HasRows.ToString());
            if (reader["oduncdurumu"] == "false")
                {
                    now.ToString("dd/MM/yyyy");
                   
                    SQLiteCommand command = new SQLiteCommand("insert into Odunc(TC,kitapid,tarih) values(@TC,@kitapid,@tarih) ", connection);
                    command.Parameters.AddWithValue("@TC", txttcno.Text);
                    command.Parameters.AddWithValue("@kitapid", kitapid);
                    command.Parameters.AddWithValue("@tarih", now.ToString());
                    SQLiteCommand command2 = new SQLiteCommand(" update Uye set oduncdurumu = @oduncdurumu ", connection);
                    command2.Parameters.AddWithValue("@oduncdurumu", "true");
                    command2.ExecuteNonQuery();

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ödünç verme işlemi başarıyla gerçekleştirildi.");
                }
                else
                {
                    MessageBox.Show("Bu üye zaten kitap ödünç aldığı için, bu kitabı ödünç alamaz.");

                }


        }


        #region üye arama
        private void txtadsoyadarama_TextChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where adsoyad like'%" + txtadsoyadarama.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
        }

        private void txttcnoarama_TextChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where id like'%" + txttcnoarama.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
        }

        #endregion

        #region kitap arama

        private void txtkitapidarama_TextChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where kitapid like'%" + txtkitapidarama.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView2.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        private void txtkitapadiarama_TextChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            daset.Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where kitapadi like'%" + txtkitapadiarama.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView2.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        #endregion

        #region rowheaderclick aksiyonları
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kitapid = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
            txttcno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtyas.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() =="true")
            {
                txtuygunluk.Text = "Uygun";
            }
            else
            {
                txtuygunluk.Text = "Uygun Değil";
            }
        }
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtkitapadi.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtyazaradi.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtstok.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        #endregion

        private void OduncVer_Click(object sender, EventArgs e)
        {
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox)
                    (controls as TextBox).Clear();
            }
        }
    }
}
