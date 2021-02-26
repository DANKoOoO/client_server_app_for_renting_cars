using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOOcena
{
    public class DodajOcenuSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            repository.Dodaj(entity);
        }
    }
}
