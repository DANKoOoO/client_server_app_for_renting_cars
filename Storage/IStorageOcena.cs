using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageOcena
    {
        void DodajOcenu(Ocena o);

        double VratiProsecnuOcenu(Automobil a);
    }
}
