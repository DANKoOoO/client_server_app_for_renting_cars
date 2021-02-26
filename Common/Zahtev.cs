using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Zahtev
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }
}
