using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorkerBP;
using Domen;

namespace Storage.Implementacija
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();

        public void ZapocniKonekciju()
        {
            broker.ZapocniKonekciju();
        }
        public void ZavrsiKonekciju()
        {
            broker.ZavrsiKonekciju();
        }
        public void Zapocnitransakciju()
        {
            broker.ZapocniTransakciju();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }
        public void Dodaj(IEntity entity)
        {
            broker.Dodaj(entity);
        }

        public int VratiID(IEntity entity)
        {
            return (int)broker.VratiID(entity);
        }

        public List<IEntity> VratiSve(IEntity entity)
        {
            return (List<IEntity>)broker.VratiSve(entity);
        }

        public List<IEntity> VratiOdredjene(IEntity entity, string pocetnaSlova)
        {
            return (List<IEntity>)broker.VratiOdredjene(entity, pocetnaSlova);
        }

        public void Izmeni(IEntity entity)
        {
            broker.Izmeni(entity);
        }

        public void Ukloni(IEntity entity)
        {
            broker.Ukloni(entity);
        }

        public void DodajSaNasledjivanjem(IEntity entity)
        {
            broker.DodajSaNasledjivanjem(entity);
        }
    }
}
