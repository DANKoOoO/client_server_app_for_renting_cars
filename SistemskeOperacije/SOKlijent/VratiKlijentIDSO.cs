using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOKlijent
{
    public class VratiKlijentIDSO : SystemOperationBase
    {
        public string Rezultat;
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            Rezultat = repository.VratiID(entity).ToString();
        }
    }
}
