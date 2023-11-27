using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornek2
{
    internal class Kullanici
    {
        string adSoyad;
        string telefon;
        string eposta;
        string sifre;
        string adres;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Adres { get => adres; set => adres = value; }

        public Kullanici(string adSoyad, string telefon, string eposta, string sifre, string adres)
        {
            this.adSoyad = adSoyad;
            this.telefon = telefon;
            this.eposta = eposta;
            this.sifre = sifre;
            this.adres = adres;
        }
    }
}
