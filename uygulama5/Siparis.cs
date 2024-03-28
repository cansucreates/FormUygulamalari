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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            groupBox1.Hide(); // groupBox1'i gizle.
            groupBox2.Hide(); // groupBox2'yi gizle.
            groupBox3.Hide(); // groupBox3'ü gizle.
            groupBox4.Hide(); // groupBox4'ü gizle.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Müşteri adı :" + textBox1.Text); // listBox1'e müşteri adını ekle.
            listBox1.Items.Add("Ödeme şekli :" + comboBox1.Text); // listBox1'e ödeme şeklini ekle. 
            listBox1.Items.Add("Sipariş no :" + textBox2.Text); // listBox1'e sipariş no ekle.
            listBox1.Items.Add("Telefon no : " + maskedTextBox1.Text); // listBox1'e telefon no ekle.
            listBox1.Items.Add("Adres : " + textBox3.Text); // listBox1'e adres ekle.
            groupBox1.Show(); // groupBox1'i göster.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) // pizza seçildiyse 
            {
                groupBox2.Show(); // comboBox2'nin seçilen indexi 0 ise groupBox2'yi göster.
                groupBox3.Hide(); // comboBox2'nin seçilen indexi 0 ise groupBox3'ü gizle.
                groupBox4.Hide(); // comboBox2'nin seçilen indexi 0 ise groupBox4'ü gizle.
                // checkBox işaretlerini kaldır.
                checkBox5.Checked = false; // checkBox5'i işaretleme.
                checkBox6.Checked = false; // checkBox6'yı işaretleme.
                checkBox8.Checked = false; // checkBox8'i işaretleme.
                checkBox9.Checked = false; // checkBox9'u işaretleme.
            }
            else if(comboBox2.SelectedIndex == 1)  // lahmacun 
            {
                groupBox2.Hide(); // comboBox2'nin seçilen indexi 1 ise groupBox2'i gizle.
                groupBox3.Show(); // comboBox2'nin seçilen indexi 1 ise groupBox3'ü göster.
                groupBox4.Hide(); // comboBox2'nin seçilen indexi 1 ise groupBox4'ü gizle.
                // checkBox işaretlerini kaldır.
                checkBox1.Checked = false; // checkBox1'i işaretleme.
                checkBox2.Checked = false; // checkBox2'yi işaretleme.
                checkBox3.Checked = false; // checkBox3'ü işaretleme.
                checkBox8.Checked = false; // checkBox8'i işaretleme.
                checkBox9.Checked = false; // checkBox9'u işaretleme.
            }
            else if(comboBox2.SelectedIndex == 2) // döner
            {
                groupBox2.Hide(); // comboBox2'nin seçilen indexi 2 ise groupBox2'yi gizle.
                groupBox3.Hide(); // comboBox2'nin seçilen indexi 2 ise groupBox3'ü gizle.
                groupBox4.Show(); // comboBox2'nin seçilen indexi 2 ise groupBox4'ü göster.
                // checkBox işaretlerini kaldır.
                checkBox1.Checked = false; // checkBox1'i işaretleme.
                checkBox2.Checked = false; // checkBox2'yi işaretleme.
                checkBox3.Checked = false; // checkBox3'ü işaretleme.
                checkBox5.Checked = false; // checkBox5'i işaretleme.
                checkBox6.Checked = false; // checkBox6'yı işaretleme.
            }

        }

        // seçilen checkbox'ların fiyatlarını listbox1'e ekleme

        private void button2_Click(object sender, EventArgs e)
        {
             if (checkBox1.Checked) // checkBox1 işaretli ise (pizza > klasik)
            {
                listBox1.Items.Add("Pizza Klasik: " + (100 * Convert.ToInt32(numericUpDown1.Value))); // listBox1'e pizza klasik fiyatını ekle.
            }
             if (checkBox2.Checked) // checkBox2 işaretli ise (pizza > vej)
            {
                listBox1.Items.Add("Pizza Vejeteryan: " + (120 * Convert.ToInt32(numericUpDown2.Value))); // listBox1'e pizza vej fiyatını ekle.
            }
             if (checkBox3.Checked) // checkBox3 işaretli ise (pizza > çiftlik) 
            {
                listBox1.Items.Add("Pizza Çiftlik: " + (110 * Convert.ToInt32(numericUpDown3.Value))); // listBox1'e pizza çiftlik fiyatını ekle.
            }
             if (checkBox9.Checked) // checkBox9 işaretli ise (doner > tavuk)
            {
                listBox1.Items.Add("Döner Tavuk: " + (170 * Convert.ToInt32(numericUpDown9.Value))); // listBox1'e döner tavuk fiyatını ekle.
            }
             if (checkBox8.Checked) // checkBox8 işaretli ise (doner > et)
            {
                listBox1.Items.Add("Döner Et: " + (200 * Convert.ToInt32(numericUpDown8.Value))); // listBox1'e döner et fiyatını ekle.
            }
             if (checkBox6.Checked) // checkBox6 işaretli ise (lahmacun > soğanlı)
            {
                listBox1.Items.Add("Lahmacun Soğanlı: " + (40 * Convert.ToInt32(numericUpDown6.Value))); // listBox1'e lahmacun soğanlı fiyatını ekle.   
            }
             if (checkBox5.Checked) // checkBox5 işaretli ise (lahmacun > fındık)
            {
                listBox1.Items.Add("Lahmacun Fındık: " + (80 * Convert.ToInt32(numericUpDown5.Value))); // listBox1'e lahmacun fındık fiyatını ekle.
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura(); // fatura nesnesini oluştur.
            fatura.Show(); // fatura formunu göster.
            foreach (string item in listBox1.Items) // listBox1'deki(siparis formundaki) tüm elemanları fatura formundaki listBox1'e ekle.
            {
                fatura.listBox1.Items.Add(item);
            }   
        }
    }
}
