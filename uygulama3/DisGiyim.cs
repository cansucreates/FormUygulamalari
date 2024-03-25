using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama3
{
    public partial class DisGiyim : Form
    {
        public DisGiyim()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Fis.Items.Add("Ürün adı: " + comboBox1.Text); // Combobox'ta seçili olan metni getirir.
            Fis.Items.Add("Ürün adı: " + comboBox1.SelectedItem);
            Fis.Items.Add("Ürün adı:  " + comboBox1.SelectedIndex);
            Fis.Items.Add("Ürün adı:  " + comboBox1.SelectedText); // Combobox'ta seçili olan seçeneği getirir.
            Fis.Items.Add("Renk: " + comboBox2.Text);
            Fis.Items.Add("Beden: " + comboBox3.Text);
            int fiyat = Convert.ToInt32(textBox1.Text);
            int adet = Convert.ToInt32(numericUpDown1.Value);
            Fis.Items.Add("Tutar: " + (fiyat * adet) + " TL");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1(); // Form1 sınıfından bir nesne oluşturuyoruz.
            anaSayfa.Show(); // Ana sayfayı açıyoruz.
            this.Hide(); // Bulunduğumuz sayfayı gizliyoruz.
        }
    }
}
