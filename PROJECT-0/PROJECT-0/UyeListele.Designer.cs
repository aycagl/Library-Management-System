namespace PROJECT_0
{
    partial class UyeListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtEmailq = new System.Windows.Forms.Label();
            this.txtAdresq = new System.Windows.Forms.Label();
            this.txtTelefonq = new System.Windows.Forms.Label();
            this.comboCinsiyetq = new System.Windows.Forms.Label();
            this.txtYasq = new System.Windows.Forms.Label();
            this.txtAdSoyadq = new System.Windows.Forms.Label();
            this.txtTcq = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtGuncelle = new System.Windows.Forms.Button();
            this.txtSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(302, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(464, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Yok"});
            this.comboCinsiyet.Location = new System.Drawing.Point(114, 181);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(129, 21);
            this.comboCinsiyet.TabIndex = 30;
            // 
            // txtEmailq
            // 
            this.txtEmailq.AutoSize = true;
            this.txtEmailq.Location = new System.Drawing.Point(58, 291);
            this.txtEmailq.Name = "txtEmailq";
            this.txtEmailq.Size = new System.Drawing.Size(41, 13);
            this.txtEmailq.TabIndex = 29;
            this.txtEmailq.Text = "E - mail";
            // 
            // txtAdresq
            // 
            this.txtAdresq.AutoSize = true;
            this.txtAdresq.Location = new System.Drawing.Point(65, 255);
            this.txtAdresq.Name = "txtAdresq";
            this.txtAdresq.Size = new System.Drawing.Size(34, 13);
            this.txtAdresq.TabIndex = 28;
            this.txtAdresq.Text = "Adres";
            // 
            // txtTelefonq
            // 
            this.txtTelefonq.AutoSize = true;
            this.txtTelefonq.Location = new System.Drawing.Point(56, 218);
            this.txtTelefonq.Name = "txtTelefonq";
            this.txtTelefonq.Size = new System.Drawing.Size(43, 13);
            this.txtTelefonq.TabIndex = 27;
            this.txtTelefonq.Text = "Telefon";
            // 
            // comboCinsiyetq
            // 
            this.comboCinsiyetq.AutoSize = true;
            this.comboCinsiyetq.Location = new System.Drawing.Point(56, 181);
            this.comboCinsiyetq.Name = "comboCinsiyetq";
            this.comboCinsiyetq.Size = new System.Drawing.Size(43, 13);
            this.comboCinsiyetq.TabIndex = 26;
            this.comboCinsiyetq.Text = "Cinsiyet";
            // 
            // txtYasq
            // 
            this.txtYasq.AutoSize = true;
            this.txtYasq.Location = new System.Drawing.Point(74, 144);
            this.txtYasq.Name = "txtYasq";
            this.txtYasq.Size = new System.Drawing.Size(25, 13);
            this.txtYasq.TabIndex = 25;
            this.txtYasq.Text = "Yaş";
            // 
            // txtAdSoyadq
            // 
            this.txtAdSoyadq.AutoSize = true;
            this.txtAdSoyadq.Location = new System.Drawing.Point(46, 103);
            this.txtAdSoyadq.Name = "txtAdSoyadq";
            this.txtAdSoyadq.Size = new System.Drawing.Size(53, 13);
            this.txtAdSoyadq.TabIndex = 24;
            this.txtAdSoyadq.Text = "Ad Soyad";
            // 
            // txtTcq
            // 
            this.txtTcq.AutoSize = true;
            this.txtTcq.Location = new System.Drawing.Point(58, 66);
            this.txtTcq.Name = "txtTcq";
            this.txtTcq.Size = new System.Drawing.Size(41, 13);
            this.txtTcq.TabIndex = 23;
            this.txtTcq.Text = "TC No.";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(114, 291);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.Location = new System.Drawing.Point(114, 255);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(130, 22);
            this.txtAdres.TabIndex = 21;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.ForeColor = System.Drawing.Color.Black;
            this.txtTelefon.Location = new System.Drawing.Point(114, 218);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 22);
            this.txtTelefon.TabIndex = 20;
            // 
            // txtYas
            // 
            this.txtYas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYas.ForeColor = System.Drawing.Color.Black;
            this.txtYas.Location = new System.Drawing.Point(114, 144);
            this.txtYas.Multiline = true;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(130, 22);
            this.txtYas.TabIndex = 19;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtAdSoyad.Location = new System.Drawing.Point(114, 103);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(130, 22);
            this.txtAdSoyad.TabIndex = 18;
            // 
            // txtTc
            // 
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTc.ForeColor = System.Drawing.Color.Black;
            this.txtTc.Location = new System.Drawing.Point(114, 66);
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(130, 22);
            this.txtTc.TabIndex = 17;
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(62, 361);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(75, 23);
            this.txtGuncelle.TabIndex = 31;
            this.txtGuncelle.Text = "Güncelle";
            this.txtGuncelle.UseVisualStyleBackColor = true;
            this.txtGuncelle.Click += new System.EventHandler(this.txtGuncelle_Click);
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(202, 361);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(75, 23);
            this.txtSil.TabIndex = 32;
            this.txtSil.Text = "Sil";
            this.txtSil.UseVisualStyleBackColor = true;
            this.txtSil.Click += new System.EventHandler(this.txtSil_Click);
            // 
            // UyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.txtEmailq);
            this.Controls.Add(this.txtAdresq);
            this.Controls.Add(this.txtTelefonq);
            this.Controls.Add(this.comboCinsiyetq);
            this.Controls.Add(this.txtYasq);
            this.Controls.Add(this.txtAdSoyadq);
            this.Controls.Add(this.txtTcq);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListele";
            this.Size = new System.Drawing.Size(783, 485);
            this.Load += new System.EventHandler(this.UyeListele_Load);
            this.EnabledChanged += new System.EventHandler(this.UyeListele_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label txtEmailq;
        private System.Windows.Forms.Label txtAdresq;
        private System.Windows.Forms.Label txtTelefonq;
        private System.Windows.Forms.Label comboCinsiyetq;
        private System.Windows.Forms.Label txtYasq;
        private System.Windows.Forms.Label txtAdSoyadq;
        private System.Windows.Forms.Label txtTcq;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button txtGuncelle;
        private System.Windows.Forms.Button txtSil;
    }
}