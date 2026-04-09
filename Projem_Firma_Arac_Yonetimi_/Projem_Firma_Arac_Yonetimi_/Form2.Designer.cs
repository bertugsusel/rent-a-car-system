namespace Projem_Firma_Arac_Yonetimi_
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.panelSol = new System.Windows.Forms.Panel();
            this.tb_plaka = new System.Windows.Forms.TextBox();
            this.lbl_plaka = new System.Windows.Forms.Label();
            this.btn_musaityap = new System.Windows.Forms.Button();
            this.btn_kirayaVer = new System.Windows.Forms.Button();
            this.cb_kiraSure = new System.Windows.Forms.ComboBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.tb_gunlukFiyat = new System.Windows.Forms.TextBox();
            this.lblGunlukFiyat = new System.Windows.Forms.Label();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.tb_yakit = new System.Windows.Forms.TextBox();
            this.lblYakit = new System.Windows.Forms.Label();
            this.tb_yıl = new System.Windows.Forms.TextBox();
            this.lblYil = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tb_marka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tb_gorev = new System.Windows.Forms.TextBox();
            this.lblGorev = new System.Windows.Forms.Label();
            this.tb_adsoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSahip = new System.Windows.Forms.Label();
            this.tb_sahip = new System.Windows.Forms.TextBox();
            this.panelSag = new System.Windows.Forms.Panel();
            this.dgv_araclar = new System.Windows.Forms.DataGridView();
            this.btn_logo = new System.Windows.Forms.Button();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSol.SuspendLayout();
            this.panelSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_araclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.BackColor = System.Drawing.Color.DimGray;
            this.lbl_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_Baslik.Location = new System.Drawing.Point(0, 0);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(1301, 50);
            this.lbl_Baslik.TabIndex = 0;
            this.lbl_Baslik.Text = "Araç Kiralama Sistemi";
            this.lbl_Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSol
            // 
            this.panelSol.BackColor = System.Drawing.Color.DarkGray;
            this.panelSol.Controls.Add(this.tb_plaka);
            this.panelSol.Controls.Add(this.lbl_plaka);
            this.panelSol.Controls.Add(this.btn_musaityap);
            this.panelSol.Controls.Add(this.btn_kirayaVer);
            this.panelSol.Controls.Add(this.cb_kiraSure);
            this.panelSol.Controls.Add(this.lblSure);
            this.panelSol.Controls.Add(this.tb_gunlukFiyat);
            this.panelSol.Controls.Add(this.lblGunlukFiyat);
            this.panelSol.Controls.Add(this.btn_yukle);
            this.panelSol.Controls.Add(this.btn_kaydet);
            this.panelSol.Controls.Add(this.btn_sil);
            this.panelSol.Controls.Add(this.btn_ekle);
            this.panelSol.Controls.Add(this.cb_sehir);
            this.panelSol.Controls.Add(this.lblSehir);
            this.panelSol.Controls.Add(this.tb_yakit);
            this.panelSol.Controls.Add(this.lblYakit);
            this.panelSol.Controls.Add(this.tb_yıl);
            this.panelSol.Controls.Add(this.lblYil);
            this.panelSol.Controls.Add(this.tb_model);
            this.panelSol.Controls.Add(this.lblModel);
            this.panelSol.Controls.Add(this.tb_marka);
            this.panelSol.Controls.Add(this.lblMarka);
            this.panelSol.Controls.Add(this.tb_gorev);
            this.panelSol.Controls.Add(this.lblGorev);
            this.panelSol.Controls.Add(this.tb_adsoyad);
            this.panelSol.Controls.Add(this.lblAdSoyad);
            this.panelSol.Controls.Add(this.lblSahip);
            this.panelSol.Controls.Add(this.tb_sahip);
            this.panelSol.Location = new System.Drawing.Point(0, 50);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(456, 655);
            this.panelSol.TabIndex = 3;
            // 
            // tb_plaka
            // 
            this.tb_plaka.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_plaka.Location = new System.Drawing.Point(120, 20);
            this.tb_plaka.Name = "tb_plaka";
            this.tb_plaka.Size = new System.Drawing.Size(200, 20);
            this.tb_plaka.TabIndex = 22;
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Location = new System.Drawing.Point(20, 20);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(34, 13);
            this.lbl_plaka.TabIndex = 21;
            this.lbl_plaka.Text = "Plaka";
            // 
            // btn_musaityap
            // 
            this.btn_musaityap.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_musaityap.ForeColor = System.Drawing.Color.White;
            this.btn_musaityap.Location = new System.Drawing.Point(329, 565);
            this.btn_musaityap.Name = "btn_musaityap";
            this.btn_musaityap.Size = new System.Drawing.Size(88, 82);
            this.btn_musaityap.TabIndex = 20;
            this.btn_musaityap.Text = "Müsait Yap";
            this.btn_musaityap.UseVisualStyleBackColor = false;
            this.btn_musaityap.Click += new System.EventHandler(this.btn_musaityap_Click);
            // 
            // btn_kirayaVer
            // 
            this.btn_kirayaVer.BackColor = System.Drawing.Color.Orange;
            this.btn_kirayaVer.ForeColor = System.Drawing.Color.White;
            this.btn_kirayaVer.Location = new System.Drawing.Point(329, 475);
            this.btn_kirayaVer.Name = "btn_kirayaVer";
            this.btn_kirayaVer.Size = new System.Drawing.Size(88, 82);
            this.btn_kirayaVer.TabIndex = 19;
            this.btn_kirayaVer.Text = "Kiraya Ver";
            this.btn_kirayaVer.UseVisualStyleBackColor = false;
            this.btn_kirayaVer.Click += new System.EventHandler(this.btn_kirayaVer_Click);
            // 
            // cb_kiraSure
            // 
            this.cb_kiraSure.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_kiraSure.FormattingEnabled = true;
            this.cb_kiraSure.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cb_kiraSure.Location = new System.Drawing.Point(120, 420);
            this.cb_kiraSure.Name = "cb_kiraSure";
            this.cb_kiraSure.Size = new System.Drawing.Size(200, 21);
            this.cb_kiraSure.TabIndex = 18;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(20, 420);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(57, 13);
            this.lblSure.TabIndex = 17;
            this.lblSure.Text = "Kira Süresi";
            // 
            // tb_gunlukFiyat
            // 
            this.tb_gunlukFiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_gunlukFiyat.Location = new System.Drawing.Point(120, 380);
            this.tb_gunlukFiyat.Name = "tb_gunlukFiyat";
            this.tb_gunlukFiyat.Size = new System.Drawing.Size(200, 20);
            this.tb_gunlukFiyat.TabIndex = 16;
            // 
            // lblGunlukFiyat
            // 
            this.lblGunlukFiyat.AutoSize = true;
            this.lblGunlukFiyat.Location = new System.Drawing.Point(20, 380);
            this.lblGunlukFiyat.Name = "lblGunlukFiyat";
            this.lblGunlukFiyat.Size = new System.Drawing.Size(66, 13);
            this.lblGunlukFiyat.TabIndex = 15;
            this.lblGunlukFiyat.Text = "Günlük Fiyat";
            // 
            // btn_yukle
            // 
            this.btn_yukle.BackColor = System.Drawing.Color.Khaki;
            this.btn_yukle.ForeColor = System.Drawing.Color.Black;
            this.btn_yukle.Location = new System.Drawing.Point(20, 612);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(280, 40);
            this.btn_yukle.TabIndex = 14;
            this.btn_yukle.Text = "Yükle";
            this.btn_yukle.UseVisualStyleBackColor = false;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_kaydet.Location = new System.Drawing.Point(20, 565);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(280, 40);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(20, 515);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(280, 40);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Seçili Aracı Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_aracSil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(20, 465);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(280, 40);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Araç Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cb_sehir
            // 
            this.cb_sehir.BackColor = System.Drawing.Color.Gainsboro;
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa",
            "Antalya",
            "Kocaeli",
            "Eskişehir",
            "Konya"});
            this.cb_sehir.Location = new System.Drawing.Point(120, 340);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(200, 21);
            this.cb_sehir.TabIndex = 10;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(20, 340);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(31, 13);
            this.lblSehir.TabIndex = 9;
            this.lblSehir.Text = "Şehir";
            // 
            // tb_yakit
            // 
            this.tb_yakit.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_yakit.ForeColor = System.Drawing.Color.Black;
            this.tb_yakit.Location = new System.Drawing.Point(120, 300);
            this.tb_yakit.Name = "tb_yakit";
            this.tb_yakit.Size = new System.Drawing.Size(200, 20);
            this.tb_yakit.TabIndex = 7;
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(20, 300);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(51, 13);
            this.lblYakit.TabIndex = 8;
            this.lblYakit.Text = "T.E Yakıt";
            // 
            // tb_yıl
            // 
            this.tb_yıl.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_yıl.ForeColor = System.Drawing.Color.Black;
            this.tb_yıl.Location = new System.Drawing.Point(120, 260);
            this.tb_yıl.Name = "tb_yıl";
            this.tb_yıl.Size = new System.Drawing.Size(200, 20);
            this.tb_yıl.TabIndex = 6;
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(20, 260);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(18, 13);
            this.lblYil.TabIndex = 7;
            this.lblYil.Text = "Yıl";
            // 
            // tb_model
            // 
            this.tb_model.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_model.ForeColor = System.Drawing.Color.Black;
            this.tb_model.Location = new System.Drawing.Point(120, 220);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(200, 20);
            this.tb_model.TabIndex = 5;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 220);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // tb_marka
            // 
            this.tb_marka.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_marka.ForeColor = System.Drawing.Color.Black;
            this.tb_marka.Location = new System.Drawing.Point(120, 180);
            this.tb_marka.Name = "tb_marka";
            this.tb_marka.Size = new System.Drawing.Size(200, 20);
            this.tb_marka.TabIndex = 4;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(20, 180);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka";
            // 
            // tb_gorev
            // 
            this.tb_gorev.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_gorev.ForeColor = System.Drawing.Color.Black;
            this.tb_gorev.Location = new System.Drawing.Point(120, 140);
            this.tb_gorev.Name = "tb_gorev";
            this.tb_gorev.Size = new System.Drawing.Size(200, 20);
            this.tb_gorev.TabIndex = 3;
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(20, 140);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(38, 13);
            this.lblGorev.TabIndex = 4;
            this.lblGorev.Text = "Görevi";
            // 
            // tb_adsoyad
            // 
            this.tb_adsoyad.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_adsoyad.ForeColor = System.Drawing.Color.Black;
            this.tb_adsoyad.Location = new System.Drawing.Point(120, 100);
            this.tb_adsoyad.Name = "tb_adsoyad";
            this.tb_adsoyad.Size = new System.Drawing.Size(200, 20);
            this.tb_adsoyad.TabIndex = 2;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 100);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblSahip
            // 
            this.lblSahip.AutoSize = true;
            this.lblSahip.ForeColor = System.Drawing.Color.Black;
            this.lblSahip.Location = new System.Drawing.Point(20, 60);
            this.lblSahip.Name = "lblSahip";
            this.lblSahip.Size = new System.Drawing.Size(64, 13);
            this.lblSahip.TabIndex = 2;
            this.lblSahip.Text = "Araç Sahibi:";
            // 
            // tb_sahip
            // 
            this.tb_sahip.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_sahip.ForeColor = System.Drawing.Color.Black;
            this.tb_sahip.Location = new System.Drawing.Point(120, 60);
            this.tb_sahip.Name = "tb_sahip";
            this.tb_sahip.Size = new System.Drawing.Size(200, 20);
            this.tb_sahip.TabIndex = 1;
            // 
            // panelSag
            // 
            this.panelSag.BackColor = System.Drawing.Color.Gray;
            this.panelSag.Controls.Add(this.dgv_araclar);
            this.panelSag.Location = new System.Drawing.Point(447, 50);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(857, 664);
            this.panelSag.TabIndex = 4;
            // 
            // dgv_araclar
            // 
            this.dgv_araclar.AllowUserToAddRows = false;
            this.dgv_araclar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_araclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_araclar.GridColor = System.Drawing.Color.Gray;
            this.dgv_araclar.Location = new System.Drawing.Point(0, 0);
            this.dgv_araclar.MultiSelect = false;
            this.dgv_araclar.Name = "dgv_araclar";
            this.dgv_araclar.ReadOnly = true;
            this.dgv_araclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_araclar.Size = new System.Drawing.Size(857, 664);
            this.dgv_araclar.TabIndex = 0;
            // 
            // btn_logo
            // 
            this.btn_logo.BackgroundImage = global::Projem_Firma_Araç_Yönetimi_.Properties.Resources.Gemini_Generated_Image_3wpbg23wpbg23wpb_Photoroom;
            this.btn_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logo.Location = new System.Drawing.Point(0, 0);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(109, 50);
            this.btn_logo.TabIndex = 5;
            this.btn_logo.UseVisualStyleBackColor = true;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.BackColor = System.Drawing.Color.DimGray;
            this.lbl_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_Tarih.Location = new System.Drawing.Point(1214, 9);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(0, 16);
            this.lbl_Tarih.TabIndex = 6;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.BackColor = System.Drawing.Color.DimGray;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.ForeColor = System.Drawing.Color.White;
            this.lbl_saat.Location = new System.Drawing.Point(1214, 34);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 16);
            this.lbl_saat.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1302, 707);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.panelSag);
            this.Controls.Add(this.panelSol);
            this.Controls.Add(this.lbl_Baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Yönetim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelSol.ResumeLayout(false);
            this.panelSol.PerformLayout();
            this.panelSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_araclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.DataGridView dgv_araclar;
        private System.Windows.Forms.TextBox tb_sahip;
        private System.Windows.Forms.TextBox tb_yakit;
        private System.Windows.Forms.TextBox tb_yıl;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_marka;
        private System.Windows.Forms.TextBox tb_gorev;
        private System.Windows.Forms.TextBox tb_adsoyad;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSahip;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.Label lblGunlukFiyat;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox tb_gunlukFiyat;
        private System.Windows.Forms.Button btn_kirayaVer;
        private System.Windows.Forms.ComboBox cb_kiraSure;
        private System.Windows.Forms.Button btn_musaityap;
        private System.Windows.Forms.TextBox tb_plaka;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
    }
}