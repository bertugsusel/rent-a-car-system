using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projem_Firma_Arac_Yonetimi_
{
    public partial class Form2 : Form
    {
        public string kullaniciTuru;

        public Form2()
        {
            InitializeComponent();
        }
        private void TxtGuncelle()
        {
            string yol = Application.StartupPath + "\\veriler.txt";
            StreamWriter sw = new StreamWriter(yol);

            for (int i = 0; i < dgv_araclar.Rows.Count; i++)
            {
                if (dgv_araclar.Rows[i].IsNewRow == false)
                {
                    string satir =
                        dgv_araclar.Rows[i].Cells["aracSahibi"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["adSoyad"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["gorev"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["marka"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["model"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["yil"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["yakit"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["sehir"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["durum"].Value + ";" +
                        dgv_araclar.Rows[i].Cells["fiyat"].Value;

                    sw.WriteLine(satir);
                }
            }

            sw.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cb_sehir.SelectedIndex = 0;

            dgv_araclar.Columns.Add("plaka", "Plaka");
            dgv_araclar.Columns.Add("aracSahibi", "Araç Sahibi");
            dgv_araclar.Columns.Add("adSoyad", "Ad Soyad");
            dgv_araclar.Columns.Add("gorev", "Görevi");
            dgv_araclar.Columns.Add("marka", "Marka");
            dgv_araclar.Columns.Add("model", "Model");
            dgv_araclar.Columns.Add("yil", "Yıl");
            dgv_araclar.Columns.Add("yakit", "Yakıt");
            dgv_araclar.Columns.Add("sehir", "Şehir");
            dgv_araclar.Columns.Add("durum", "Durum");
            dgv_araclar.Columns.Add("fiyat", "Toplam Fiyat");

            if (kullaniciTuru == "personel")
            {
                tb_sahip.Enabled = false;
                tb_adsoyad.Enabled = false;
                tb_gorev.Enabled = false;
                tb_marka.Enabled = false;
                tb_model.Enabled = false;
                tb_yıl.Enabled = false;
                tb_yakit.Enabled = false;
                cb_sehir.Enabled = false;
                btn_ekle.Enabled = false;
                btn_sil.Enabled = false;
                btn_kaydet.Enabled = false;
                btn_yukle.Enabled = true;
                btn_kirayaVer.Enabled = false;
                btn_musaityap.Enabled = false;
            }

        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int teslimYakit;

            try
            {
                teslimYakit = Convert.ToInt32(tb_yakit.Text);

                if (teslimYakit < 0 || teslimYakit > 100)
                {
                    MessageBox.Show("Yakıt 0 ile 100 arasında olmalı");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Yakıt yüzde olarak sayı girilmeli");
                return;
            }

            dgv_araclar.Rows.Add(
                tb_plaka.Text,
                tb_sahip.Text,
                tb_adsoyad.Text,
                tb_gorev.Text,
                tb_marka.Text,
                tb_model.Text,
                tb_yıl.Text,
                teslimYakit.ToString() + "%",
                cb_sehir.Text,
                "Müsait"
            );
            MessageBox.Show("Araç eklendi");
        }
        private void btn_aracSil_Click(object sender, EventArgs e)
        {
            if (dgv_araclar.SelectedRows.Count > 0)
            {
                dgv_araclar.Rows.RemoveAt(dgv_araclar.SelectedRows[0].Index);
                TxtGuncelle();
                MessageBox.Show("Araç silindi");
            }
            else
            {
                MessageBox.Show("Silmek için bir araç seç");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("veriler.txt");

            if (dgv_araclar.Rows.Count == 0)
            {
                MessageBox.Show("Kaydedilecek araç yok");
            }
            else
            {
                for (int i = 0; i < dgv_araclar.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_araclar.Columns.Count; j++)
                    {
                        sw.Write(dgv_araclar.Rows[i].Cells[j].Value + "|");
                    }
                    sw.WriteLine();
                }

                MessageBox.Show("Kaydedildi");
            }

            sw.Close();
        }


        private void btn_yukle_Click(object sender, EventArgs e)
        {
            if (File.Exists("veriler.txt"))
            {
                dgv_araclar.Rows.Clear();

                StreamReader sr = new StreamReader("veriler.txt");
                string satir;

                while ((satir = sr.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split('|');
                    dgv_araclar.Rows.Add(parcalar);
                }

                sr.Close();
                MessageBox.Show("Yüklendi");
            }
            else
            {
                MessageBox.Show("Kayıt dosyası bulunamadı");
            }
        }
        private void btn_kirayaVer_Click(object sender, EventArgs e)
        {

            if (dgv_araclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bir araç seç");
                return;
            }

            int ay;
            int gunlukFiyat;

            try
            {
                ay = Convert.ToInt32(cb_kiraSure.Text);
                gunlukFiyat = Convert.ToInt32(tb_gunlukFiyat.Text);
            }
            catch
            {
                MessageBox.Show("Ay ve günlük fiyat sayı olmalı");
                return;
            }

            int toplamGun = ay * 30;
            int toplamFiyat = toplamGun * gunlukFiyat;

            
            if (ay == 6)
            {
                toplamFiyat = toplamFiyat - (toplamFiyat * 15 / 100);
            }
            else if (ay == 12)
            {
                toplamFiyat = toplamFiyat - (toplamFiyat * 30 / 100);
            }
            dgv_araclar.SelectedRows[0].Cells["fiyat"].Value = toplamFiyat.ToString();

            
            dgv_araclar.SelectedRows[0].Cells["durum"].Value = "Kirada";

            MessageBox.Show("Araç kiralandı\nToplam ücret: " + toplamFiyat + " TL");
        }

        private void btn_musaityap_Click(object sender, EventArgs e)
        {
            if (dgv_araclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bir araç seç");
            }
            else
            {
                
                int secilenIndex = dgv_araclar.SelectedRows[0].Index;

               
                dgv_araclar.Rows[secilenIndex].Cells["Durum"].Value = "Müsait";

                
                StreamWriter sw = new StreamWriter("veriler.txt");

                for (int i = 0; i < dgv_araclar.Rows.Count; i++)
                {
                }

                sw.Close();

                MessageBox.Show("Araç müsait yapıldı");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
            lbl_saat.Text = DateTime.Now.ToLongTimeString();

        }
    }
}








