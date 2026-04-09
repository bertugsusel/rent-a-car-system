namespace Projem_Firma_Arac_Yonetimi_
{
    partial class Form1
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
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_kullaniciadi = new System.Windows.Forms.TextBox();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_baslik.Location = new System.Drawing.Point(150, 30);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(169, 29);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "ADMİN GİRİŞ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tb_kullaniciadi
            // 
            this.tb_kullaniciadi.Location = new System.Drawing.Point(200, 100);
            this.tb_kullaniciadi.Name = "tb_kullaniciadi";
            this.tb_kullaniciadi.Size = new System.Drawing.Size(160, 20);
            this.tb_kullaniciadi.TabIndex = 2;
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(200, 140);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(160, 20);
            this.tb_sifre.TabIndex = 3;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(170, 190);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(110, 35);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_kullaniciadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Araç Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_kullaniciadi;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_giris;
    }
}

