using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikNoDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            TCKimlikNoDogrulamaServisi.KPSPublic kps = new TCKimlikNoDogrulamaServisi.KPSPublic();
           bool sonuc= kps.TCKimlikNoDogrula(long.Parse(txtTc.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), int.Parse(txtDogumYili.Text));
            if (sonuc)
            {
                MessageBox.Show("TC Kimlik No Doğrulandı");
            }
            else
            {
                MessageBox.Show("TC Kimlik No Doğrulanmadı");
            }
        }
    }
}
