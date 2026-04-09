using Projem_Firma_Arac_Yonetimi_;
using System;
using System.Windows.Forms;
namespace Projem_Firma_Arac_Yonetimi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tb_kullaniciadi.Text;
            string sifre = tb_sifre.Text;

            Form2 frm = new Form2();

            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                frm.kullaniciTuru = "admin";
                frm.Show();
                this.Hide();
            }
            else if (kullaniciAdi == "personel" && sifre == "1111")
            {
                frm.kullaniciTuru = "personel";
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }
    }
}