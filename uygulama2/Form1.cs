using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            char secim = Convert.ToChar(textBox3.Text);

            switch(secim)
            {
                case '+':
                    int toplam = sayi1 + sayi2;
                    label5.Text = toplam.ToString();
                    break;
                case '-':
                    int fark = sayi1 - sayi2;
                    label5.Text = fark.ToString();
                    break;
                case '*':
                    int carpim = sayi1 * sayi2;
                    label5.Text = carpim.ToString();
                    break;
                case '/':
                    int bolum = sayi1 / sayi2;
                    label5.Text = bolum.ToString();
                    break;
                default:
                    MessageBox.Show("Hatalı işlem seçimi!");
                    break;

            }
        }

    }
}
