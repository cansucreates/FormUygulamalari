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
    public partial class MusteriBilgi : Form
    {
        public MusteriBilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracSatis aracSatis = new AracSatis();

            aracSatis.listBox1.Items.Add("Müşteri adı : " + textBox1.Text);
            aracSatis.listBox1.Items.Add("Müşteri soyadı : " + textBox2.Text);
            aracSatis.listBox1.Items.Add("Telefon no : " + maskedTextBox1.Text);
            aracSatis.listBox1.Items.Add("Adres : " + textBox3.Text);
  
            aracSatis.Show();
            this.Hide();
        }
    }
}
