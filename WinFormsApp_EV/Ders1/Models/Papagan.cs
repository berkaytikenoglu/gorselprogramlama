using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Ders1.Models
{
    internal class Papagan : Kuslar
    {

        public String? Renk;
        public String? Isim;

        public override string sescikar()
        {
            return "babacık"; 
        }
    }
}
