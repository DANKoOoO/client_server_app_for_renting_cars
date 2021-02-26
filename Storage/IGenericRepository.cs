using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        void Dodaj(IEntity entity);
        int VratiID(IEntity entity);
        List<IEntity> VratiSve(IEntity entity);
        List<IEntity> VratiOdredjene(IEntity entity, string pocetnaSlova);
        void Izmeni(IEntity entity);
        void Ukloni(IEntity entity);
        void DodajSaNasledjivanjem(IEntity entity);
        void ZapocniKonekciju();
        void ZavrsiKonekciju();
        void Zapocnitransakciju();
        void Commit();
        void Rollback();
    }
}
