using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // linkler
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.ibb.gov.tr"); // linkLabel1'e tıklandığında www.ibb.gov.tr adresine git.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe"); // linkLabel2'ye tıklandığında hesap makinesi aç.
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Windows NT\\Accessories\\wordpad.exe"); // linkLabel3'e tıklandığında wordpadi aç.
        }

        // giriş butonu eventi
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "Serap";
            string sifre = "1234";

            if(textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                Siparis siparis = new Siparis(); // siparis nesnesini oluştur. görüntülemek için.
                siparis.Show(); // siparis formunu göster.
                this.Hide(); // Form1'i gizle.
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!"); // kullanıcı adı veya şifre hatalıysa hata mesajı ver.
            }
        }
    }
}
