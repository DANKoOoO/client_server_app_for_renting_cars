using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOAutomobil
{
    public class IzmeniStanjeAutomobilaSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            List<Iznajmljivanje> iznajmljivanja = repository.VratiSve(new Iznajmljivanje()).Cast<Iznajmljivanje>().ToList();
            foreach (Automobil a in (List<Automobil>)parametri)
            {
                foreach (Iznajmljivanje i in iznajmljivanja)
                {
                    if (i.AutomobilID == a.ID)
                    {
                        repository.Ukloni(i);
                    }
                }
                repository.Izmeni(a);        

            }
        }
    }
}
