using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracGalerisi
{
    public partial class AracSatis : Form
    {
        public AracSatis()
        {
            InitializeComponent();
        }


        private void AracSatis_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // audi seçildiyse
            {
                groupBox2.Show();
                groupBox3.Hide();
                groupBox4.Hide();

                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                textBox1.Clear();
                textBox3.Clear();


            }
            else if (comboBox1.SelectedIndex == 1) // mercedes seçildiyse
            {
                groupBox2.Hide();
                groupBox3.Show();
                groupBox4.Hide();

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                textBox2.Clear();
                textBox3.Clear();

            }
            else if (comboBox1.SelectedIndex == 2) // tesla seçildiyse
            {
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Show();


                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        int a4Fiyat = 100000;
        int a6Fiyat = 200000;
        int a5Fiyat = 300000;
        int kilifFiyat = 200;
        int telefonTutucuFiyat = 500;
        int c180Fiyat = 100000;
        int c200Fiyat = 200000;
        int modelSfFiyat = 200000;
        int toplamTeslaFiyat = 0;
        int toplamMercedesFiyat = 0;
        int toplamFiyat = 0;

        // fiyat textboxını güncelleme
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // audi seçildiyse

            if (comboBox2.SelectedIndex == 0)
            {
                toplamFiyat = a4Fiyat + telefonTutucuFiyat;
                textBox2.Text = toplamFiyat.ToString();
            }
            if (comboBox2.SelectedIndex == 0)
            {

                toplamFiyat = a4Fiyat + kilifFiyat;
                textBox2.Text = toplamFiyat.ToString();

            }
            if (comboBox2.SelectedIndex == 1)
            {
                toplamFiyat = a5Fiyat + telefonTutucuFiyat;
                textBox2.Text = toplamFiyat.ToString();

            }
            if (comboBox2.SelectedIndex == 1)
            {
                toplamFiyat = a5Fiyat + kilifFiyat;
                textBox2.Text = toplamFiyat.ToString();

            }
            if (comboBox2.SelectedIndex == 2)
            {
                toplamFiyat = a6Fiyat + telefonTutucuFiyat;
                textBox2.Text = toplamFiyat.ToString();

            }
            if (comboBox2.SelectedIndex == 2)
            {
                toplamFiyat = a6Fiyat + kilifFiyat;
                textBox2.Text = toplamFiyat.ToString();

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            // mercedes seçildiyse


            if (comboBox3.SelectedIndex == 0)
            {
                toplamMercedesFiyat = c180Fiyat + telefonTutucuFiyat;
                textBox1.Text = toplamMercedesFiyat.ToString();

            }
            if (comboBox3.SelectedIndex == 0)
            {
                toplamMercedesFiyat = c180Fiyat + kilifFiyat;
                textBox1.Text = toplamMercedesFiyat.ToString();

            }
            if (comboBox3.SelectedIndex == 1)
            {
                toplamMercedesFiyat = c200Fiyat + telefonTutucuFiyat;
                textBox1.Text = toplamMercedesFiyat.ToString();

            }
            if (comboBox3.SelectedIndex == 1)
            {
                toplamMercedesFiyat = c200Fiyat + kilifFiyat;
                textBox1.Text = toplamMercedesFiyat.ToString();
  
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tesla seçildiyse

            if (comboBox6.SelectedIndex == 0)
            {
                toplamTeslaFiyat = modelSfFiyat + telefonTutucuFiyat;
                ;
                textBox3.Text = toplamTeslaFiyat.ToString();

            }
            if (comboBox6.SelectedIndex == 0)
            {
                toplamTeslaFiyat = modelSfFiyat + kilifFiyat;
                textBox3.Text = toplamTeslaFiyat.ToString();
            }
        }

        // listboxa ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && radioButton1.Checked == true)
            {
                toplamFiyat = a4Fiyat + telefonTutucuFiyat;
                listBox1.Items.Add("Audi A4 : " + a4Fiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }
            if (comboBox2.SelectedIndex == 0 && radioButton2.Checked == true)
            {

                toplamFiyat = a4Fiyat + kilifFiyat;
                listBox1.Items.Add("Audi A4 : " + a4Fiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }
            if (comboBox2.SelectedIndex == 1 && radioButton1.Checked == true)
            {
                toplamFiyat = a5Fiyat + telefonTutucuFiyat;
                listBox1.Items.Add("Audi A5 : " + a5Fiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }
            if (comboBox2.SelectedIndex == 1 && radioButton2.Checked == true)
            {
                toplamFiyat = a5Fiyat + kilifFiyat;
                listBox1.Items.Add("Audi A5 : " + a5Fiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }
            if (comboBox2.SelectedIndex == 2 && radioButton1.Checked == true)
            {
                toplamFiyat = a6Fiyat + telefonTutucuFiyat;
                listBox1.Items.Add("Audi A6 : " + a6Fiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }
            if (comboBox2.SelectedIndex == 2 && radioButton2.Checked == true)
            {
                toplamFiyat = a6Fiyat + kilifFiyat;
                listBox1.Items.Add("Audi A6 : " + a6Fiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamFiyat);
            }


            // mercedes seçildiyse


            if (comboBox3.SelectedIndex == 0 && radioButton4.Checked == true)
            {
                toplamMercedesFiyat = c180Fiyat + telefonTutucuFiyat;
 
                listBox1.Items.Add("Mercedes C180 : " + c180Fiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamMercedesFiyat);
            }
            if (comboBox3.SelectedIndex == 0 && radioButton3.Checked == true)
            {
                toplamMercedesFiyat = c180Fiyat + kilifFiyat;

                listBox1.Items.Add("Mercedes C180 : " + c180Fiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamMercedesFiyat);
            }
            if (comboBox3.SelectedIndex == 1 && radioButton4.Checked == true)
            {
                toplamMercedesFiyat = c200Fiyat + telefonTutucuFiyat;
 
                listBox1.Items.Add("Mercedes C200 : " + c200Fiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamMercedesFiyat);
            }
            if (comboBox3.SelectedIndex == 1 && radioButton3.Checked == true)
            {
                toplamMercedesFiyat = c200Fiyat + kilifFiyat;

                listBox1.Items.Add("Mercedes C200 : " + c200Fiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamMercedesFiyat);
            }


            // tesla seçildiyse



            if (comboBox6.SelectedIndex == 0 && radioButton6.Checked == true)
            {
                toplamTeslaFiyat = modelSfFiyat + telefonTutucuFiyat;
                ;
                listBox1.Items.Add("Tesla Model S : " + modelSfFiyat);
                listBox1.Items.Add("Telefon Tutucu : " + telefonTutucuFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamTeslaFiyat);
            }
            if (comboBox6.SelectedIndex == 0 && radioButton5.Checked == true)
            {
                toplamTeslaFiyat = modelSfFiyat + kilifFiyat;

                listBox1.Items.Add("Tesla Model S : " + modelSfFiyat);
                listBox1.Items.Add("Kılıf : " + kilifFiyat);
                listBox1.Items.Add("Toplam Fiyat : " + toplamTeslaFiyat);
            }

        }


    }
}
