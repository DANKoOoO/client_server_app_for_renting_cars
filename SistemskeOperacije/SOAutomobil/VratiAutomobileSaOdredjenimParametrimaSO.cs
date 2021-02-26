using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOAutomobil
{
    public class VratiAutomobileSaOdredjenimParametrimaSO : SystemOperationBase
    {
        public List<Automobil> Rezultat = new List<Automobil>();
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            Automobil au = (Automobil)entity;
            if (au.Registracija != null && !string.IsNullOrWhiteSpace(au.Registracija))
            {
                foreach (Automobil a in repository.VratiSve(entity).Cast<Automobil>().ToList())
                {
                    if (a.Registracija == au.Registracija)
                    {
                        Rezultat.Add(a);
                        return;
                    }
                }
                Rezultat = null;
                return;
            }

            foreach (Automobil a in repository.VratiSve(entity).Cast<Automobil>().ToList())
            {
                if (a.Kubikaza > au.Kubikaza)
                {
                    continue;
                }
                if (au.Marka != "nebitno" && au.Marka != a.Marka)
                {
                    continue;
                }
                if (au.Model != "nebitno" && au.Model != a.Model)
                {
                    continue;
                }
                Rezultat.Add(a);
            }
        }
    }
}
