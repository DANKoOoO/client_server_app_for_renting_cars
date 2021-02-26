using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOAutomobil
{
    public class UkloniAutomobilSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            foreach (Automobil a in (List<Automobil>)parametri)
            {
                repository.Ukloni(a);
            }
        }
    }
}
