using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Ders1.Models
{
    internal class Notlar
    {

        public double Sinav1;
        public double Sinav2;
        public double Sinav3;
        public double ortalama;
        public Notlar(double Sinav1, double Sinav2, double Sinav3)
        {

            this.Sinav1 = Sinav1;
            this.Sinav2 = Sinav2;
            this.Sinav3 = Sinav3;
            double ortalama = (Sinav1 + Sinav2 + Sinav3) / 3;
            this.ortalama = Math.Round(ortalama, 2);

        }
    }
}
