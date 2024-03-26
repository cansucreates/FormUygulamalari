using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yiyecekler
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1'de seçilirse comboBox2 ve comboBox3'ü temizliyoruz.
            comboBox2.Text = "";
            comboBox3.Text = "";

            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
          
            // comboBox1'de seçilen değere göre textBox1'e fiyatı yazdırıyoruz.


            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "150";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "200";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "250";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "300";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox3.Text = "";

            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = "50";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                textBox1.Text = "100";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox1.Text = "";

            textBox1.Text = "110";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        int tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1 && comboBox1.Text != "") // seçili değilse
            {
                listBox1.Items.Add("Dürüm: " + comboBox1.SelectedItem);
            }
            else if (comboBox2.SelectedIndex != -1 && comboBox2.Text != "")  // boş değilse
            {
                listBox1.Items.Add("Çorba: " + comboBox2.SelectedItem);
            }
            else if (comboBox3.SelectedIndex != -1 && comboBox3.Text != "")
            {
                listBox1.Items.Add("Tatlı: " + comboBox3.SelectedItem); 
            }

            listBox1.Items.Add("Adet: " + textBox2.Text);
            int toplam = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add("Toplam: " + toplam);
            tutar += toplam;
            listBox1.Items.Add("Tutar: " + tutar);

        }

        // İçecekler
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // toplam limonata fiyatı
                int fiyat = 20 * Convert.ToInt32(numericUpDown1.Value);
                tutar += fiyat;
                listBox1.Items.Add("Limonata: " + fiyat);
            }
            if(checkBox2.Checked == true)
            {
                // toplam ayran fiyatı
                int fiyat = 10 * Convert.ToInt32(numericUpDown2.Value);
                tutar += fiyat;
                listBox1.Items.Add("Ayran: " + fiyat);
            }
            if(checkBox3.Checked == true)
            {
                // toplam soda fiyatı
                int fiyat = 15 * Convert.ToInt32(numericUpDown3.Value);
                tutar += fiyat;
                listBox1.Items.Add("Soda: " + fiyat);
            }

        } 

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Show();

            foreach (string i in listBox1.Items)
            {
                fatura.fis.Items.Add(i);
            }
            fatura.fis.Items.Add("Toplam Tutar: " + tutar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             listBox1.Hide();
        }

 
    }
}
