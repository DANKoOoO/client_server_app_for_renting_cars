using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOIznajmljivanje
{
    public class DodajIznajmljivanjeSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            List<Automobil> automobili = repository.VratiSve(new Automobil()).Cast<Automobil>().ToList();
            foreach (Iznajmljivanje i in (List<Iznajmljivanje>)parametri)
            {
                foreach(Automobil a in automobili)
                {
                    if(a.ID == i.AutomobilID)
                    {
                        a.Stanje = Stanja.iznajmljen;
                        repository.Izmeni(a);
                    }
                }
                repository.Dodaj(i);
            }
        }
    }
}
