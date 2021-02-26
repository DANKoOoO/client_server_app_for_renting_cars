using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOKlijent
{
    public class VratiClanoveSaPocetnimSlovimaSO : SystemOperationBase
    {
        public List<Clan> Rezultat = new List<Clan>();
        protected override void Izvrsi(IEntity entity, object pocetnaSlova)
        {
            Rezultat = repository.VratiOdredjene(entity, (string)pocetnaSlova).Cast<Clan>().ToList();
        }
  
    }
}
