using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOAutomobil
{
    public class VratiSveAutomobileSO : SystemOperationBase
    {
        public List<Automobil> Rezultat;
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            Rezultat = repository.VratiSve(entity).Cast<Automobil>().ToList();
        }
    }
}
