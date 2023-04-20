namespace PROJECT_0
{
    partial class uyeadminselect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeadminselect));
            this.adminbtn = new System.Windows.Forms.Button();
            this.uyebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.Wheat;
            this.adminbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.adminbtn.FlatAppearance.BorderSize = 0;
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminbtn.ForeColor = System.Drawing.Color.Black;
            this.adminbtn.Location = new System.Drawing.Point(83, 329);
            this.adminbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(254, 56);
            this.adminbtn.TabIndex = 1;
            this.adminbtn.Text = "Admin Girişi";
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // uyebtn
            // 
            this.uyebtn.BackColor = System.Drawing.Color.Wheat;
            this.uyebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uyebtn.FlatAppearance.BorderSize = 0;
            this.uyebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyebtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyebtn.Location = new System.Drawing.Point(83, 219);
            this.uyebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uyebtn.Name = "uyebtn";
            this.uyebtn.Size = new System.Drawing.Size(254, 56);
            this.uyebtn.TabIndex = 2;
            this.uyebtn.Text = "Üye Girişi";
            this.uyebtn.UseVisualStyleBackColor = false;
            this.uyebtn.Click += new System.EventHandler(this.uyebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uyeadminselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.uyebtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uyeadminselect";
            this.Size = new System.Drawing.Size(428, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button uyebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
