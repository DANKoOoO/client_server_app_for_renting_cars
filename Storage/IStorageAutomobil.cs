using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageAutomobil
    {
        List<Automobil> VratiSveAutomobile();

        void DodajAutomobil(Automobil a);

        void ObrisiAutomobil(List<Automobil> listaZaBrisanje);
        void IzmeniAutomobil(Automobil a);
    }
}
