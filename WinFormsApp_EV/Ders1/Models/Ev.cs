using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Ders1.Models
{
    internal class Ev
    {

        public string RENK;
        public string KAT;
        public double FIYAT;
        public string YAKIT;

        public Ev(string Renk, string Kat, double Fiyat, string Yakit)
        {
            RENK = Renk; // Doğru değişken kullanımı Renk, RENK değil
            KAT = Kat;
            FIYAT = Fiyat;
            YAKIT = Yakit;
        }
    }
}
