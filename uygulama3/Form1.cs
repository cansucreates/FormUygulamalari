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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dışGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisGiyim giyim = new DisGiyim(); // DisGiyim sınıfından bir nesne oluşturuyoruz.
            giyim.Show(); // dis giyim sayfasını açıyoruz. (Giyim > Dış Giyim'e tıkladığımızda dış giyim sayfası açılacak.)
            // this.Close(); // Form1 sayfasını kapatıyoruz.(Yani bulunduğumuz sayfayı kapatıyoruz.)
            this.Hide(); // Form1 sayfasını gizliyoruz. (Yani bulunduğumuz sayfayı gizliyoruz.)
        }
    }
}
