using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_EV.Models
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string Ders;

        public Ogrenci(string Ad, string Soyad, string Ders)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Ders = Ders;
        }

    }

}
