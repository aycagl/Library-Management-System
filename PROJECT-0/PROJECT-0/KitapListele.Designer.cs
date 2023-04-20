namespace PROJECT_0
{
    partial class KitapListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSil = new System.Windows.Forms.Button();
            this.txtGuncelle = new System.Windows.Forms.Button();
            this.txtEmailq = new System.Windows.Forms.Label();
            this.txtAdresq = new System.Windows.Forms.Label();
            this.txtTelefonq = new System.Windows.Forms.Label();
            this.comboCinsiyetq = new System.Windows.Forms.Label();
            this.txtYasq = new System.Windows.Forms.Label();
            this.txtAdSoyadq = new System.Windows.Forms.Label();
            this.txtTcq = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBaskiSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.txtAdetSayisi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboKitapDurumu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(191, 387);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(75, 23);
            this.txtSil.TabIndex = 48;
            this.txtSil.Text = "Sil";
            this.txtSil.UseVisualStyleBackColor = true;
            this.txtSil.Click += new System.EventHandler(this.txtSil_Click);
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(66, 387);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(75, 23);
            this.txtGuncelle.TabIndex = 47;
            this.txtGuncelle.Text = "Güncelle";
            this.txtGuncelle.UseVisualStyleBackColor = true;
            this.txtGuncelle.Click += new System.EventHandler(this.txtGuncelle_Click);
            // 
            // txtEmailq
            // 
            this.txtEmailq.AutoSize = true;
            this.txtEmailq.Location = new System.Drawing.Point(74, 242);
            this.txtEmailq.Name = "txtEmailq";
            this.txtEmailq.Size = new System.Drawing.Size(23, 13);
            this.txtEmailq.TabIndex = 45;
            this.txtEmailq.Text = "Tür";
            // 
            // txtAdresq
            // 
            this.txtAdresq.AutoSize = true;
            this.txtAdresq.Location = new System.Drawing.Point(64, 206);
            this.txtAdresq.Name = "txtAdresq";
            this.txtAdresq.Size = new System.Drawing.Size(34, 13);
            this.txtAdresq.TabIndex = 44;
            this.txtAdresq.Text = "Yazar";
            // 
            // txtTelefonq
            // 
            this.txtTelefonq.AutoSize = true;
            this.txtTelefonq.Location = new System.Drawing.Point(49, 169);
            this.txtTelefonq.Name = "txtTelefonq";
            this.txtTelefonq.Size = new System.Drawing.Size(49, 13);
            this.txtTelefonq.TabIndex = 43;
            this.txtTelefonq.Text = "Kitap Adı";
            // 
            // comboCinsiyetq
            // 
            this.comboCinsiyetq.AutoSize = true;
            this.comboCinsiyetq.Location = new System.Drawing.Point(38, 131);
            this.comboCinsiyetq.Name = "comboCinsiyetq";
            this.comboCinsiyetq.Size = new System.Drawing.Size(59, 13);
            this.comboCinsiyetq.TabIndex = 42;
            this.comboCinsiyetq.Text = "Adet Sayısı";
            // 
            // txtYasq
            // 
            this.txtYasq.AutoSize = true;
            this.txtYasq.Location = new System.Drawing.Point(26, 95);
            this.txtYasq.Name = "txtYasq";
            this.txtYasq.Size = new System.Drawing.Size(71, 13);
            this.txtYasq.TabIndex = 41;
            this.txtYasq.Text = "Kitap Durumu";
            // 
            // txtAdSoyadq
            // 
            this.txtAdSoyadq.AutoSize = true;
            this.txtAdSoyadq.Location = new System.Drawing.Point(20, 53);
            this.txtAdSoyadq.Name = "txtAdSoyadq";
            this.txtAdSoyadq.Size = new System.Drawing.Size(77, 13);
            this.txtAdSoyadq.TabIndex = 40;
            this.txtAdSoyadq.Text = "Eklenme Tarihi";
            // 
            // txtTcq
            // 
            this.txtTcq.AutoSize = true;
            this.txtTcq.Location = new System.Drawing.Point(53, 17);
            this.txtTcq.Name = "txtTcq";
            this.txtTcq.Size = new System.Drawing.Size(45, 13);
            this.txtTcq.TabIndex = 39;
            this.txtTcq.Text = "Kitap ID";
            this.txtTcq.Click += new System.EventHandler(this.txtTcq_Click);
            // 
            // txtTur
            // 
            this.txtTur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTur.Location = new System.Drawing.Point(110, 242);
            this.txtTur.Multiline = true;
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(130, 21);
            this.txtTur.TabIndex = 38;
            // 
            // txtYazar
            // 
            this.txtYazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazar.Location = new System.Drawing.Point(110, 206);
            this.txtYazar.Multiline = true;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(130, 21);
            this.txtYazar.TabIndex = 37;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Location = new System.Drawing.Point(110, 169);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(130, 21);
            this.txtKitapAdi.TabIndex = 36;
            // 
            // txtKitapID
            // 
            this.txtKitapID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapID.Location = new System.Drawing.Point(110, 17);
            this.txtKitapID.Multiline = true;
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.ReadOnly = true;
            this.txtKitapID.Size = new System.Drawing.Size(130, 21);
            this.txtKitapID.TabIndex = 33;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(110, 278);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(129, 20);
            this.txtSayfaSayisi.TabIndex = 49;
            // 
            // txtBaskiSayisi
            // 
            this.txtBaskiSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaskiSayisi.Location = new System.Drawing.Point(110, 313);
            this.txtBaskiSayisi.Name = "txtBaskiSayisi";
            this.txtBaskiSayisi.Size = new System.Drawing.Size(129, 20);
            this.txtBaskiSayisi.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Sayfa Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Baskı Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Basım Yılı";
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasimYili.Location = new System.Drawing.Point(110, 345);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(129, 20);
            this.txtBasimYili.TabIndex = 54;
            // 
            // txtAdetSayisi
            // 
            this.txtAdetSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdetSayisi.Location = new System.Drawing.Point(110, 131);
            this.txtAdetSayisi.Name = "txtAdetSayisi";
            this.txtAdetSayisi.Size = new System.Drawing.Size(129, 20);
            this.txtAdetSayisi.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(393, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(607, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 58;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(548, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Yazar Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(338, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Kitap Adı";
            // 
            // comboKitapDurumu
            // 
            this.comboKitapDurumu.FormattingEnabled = true;
            this.comboKitapDurumu.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.comboKitapDurumu.Location = new System.Drawing.Point(110, 92);
            this.comboKitapDurumu.Name = "comboKitapDurumu";
            this.comboKitapDurumu.Size = new System.Drawing.Size(129, 21);
            this.comboKitapDurumu.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(281, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(460, 341);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtEklenmeTarihi
            // 
            this.txtEklenmeTarihi.Location = new System.Drawing.Point(110, 53);
            this.txtEklenmeTarihi.Name = "txtEklenmeTarihi";
            this.txtEklenmeTarihi.Size = new System.Drawing.Size(130, 20);
            this.txtEklenmeTarihi.TabIndex = 64;
            // 
            // KitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtEklenmeTarihi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboKitapDurumu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAdetSayisi);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaskiSayisi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.txtEmailq);
            this.Controls.Add(this.txtAdresq);
            this.Controls.Add(this.txtTelefonq);
            this.Controls.Add(this.comboCinsiyetq);
            this.Controls.Add(this.txtYasq);
            this.Controls.Add(this.txtAdSoyadq);
            this.Controls.Add(this.txtTcq);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapID);
            this.Name = "KitapListele";
            this.Size = new System.Drawing.Size(788, 492);
            this.Load += new System.EventHandler(this.KitapListele_Load);
            this.EnabledChanged += new System.EventHandler(this.KitapListele_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSil;
        private System.Windows.Forms.Button txtGuncelle;
        private System.Windows.Forms.Label txtEmailq;
        private System.Windows.Forms.Label txtAdresq;
        private System.Windows.Forms.Label txtTelefonq;
        private System.Windows.Forms.Label comboCinsiyetq;
        private System.Windows.Forms.Label txtYasq;
        private System.Windows.Forms.Label txtAdSoyadq;
        private System.Windows.Forms.Label txtTcq;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBaskiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.TextBox txtAdetSayisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboKitapDurumu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txtEklenmeTarihi;
    }
}