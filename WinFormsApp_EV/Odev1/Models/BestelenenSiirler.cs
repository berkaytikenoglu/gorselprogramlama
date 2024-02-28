using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Odev1.Models
{
    internal class BestelenenSiirler : Siir
    {
        public string? yazar;
        public string? siirAdi;
        public long? satirSayisi;
        public string? besteleyenkisi;
        public long? bestelenmetarih;


        public virtual string Aciklama() { return "Bu açıklama bestelenmiş şiir sınıfına aitti"; }

    }


}
