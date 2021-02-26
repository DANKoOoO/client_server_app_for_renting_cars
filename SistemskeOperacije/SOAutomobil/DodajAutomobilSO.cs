using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOAutomobil
{
    public class DodajAutomobilSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            foreach (Automobil a in repository.VratiSve(entity).Cast<Automobil>().ToList())
            {
                if (((Automobil)entity).Registracija == a.Registracija)
                {
                    throw new Exception("Vec postoji automobil sa tom registracijom u sistemu!");
                }
            }
            repository.Dodaj(entity);
        }
    }
}
