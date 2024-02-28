using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Odev1.Models
{
    internal class Siir
    {
        public string? yazar;
        public string? siirAdi;
        public int satirSayisi;

        public virtual string Aciklama() { return ""; }

    }
}
