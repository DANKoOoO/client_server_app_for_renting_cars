using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.SOKlijent
{
    public class VratiSveClanoveSO : SystemOperationBase
    {
        public List<Clan> Rezultat = new List<Clan>();
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            Clan cl = (Clan)entity;
            Rezultat = repository.VratiSve(cl).Cast<Clan>().ToList();
           
        }
    }

}
