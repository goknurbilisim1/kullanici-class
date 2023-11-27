using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adSoyad=Convert.ToString(txtAdSoyad.Text);
            string telefon=Convert.ToString(txtTelefon.Text);
            string ePosta=Convert.ToString(txtEPosta.Text);
            string sifre=Convert.ToString(txtSifre.Text);
            string adres=Convert.ToString(txtAdres.Text);
            
            Kullanici kullanici1 = new Kullanici(adSoyad,telefon,ePosta,sifre,adres);

        }
    }
}
