using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorkerBP;
using Domen;

namespace Storage.Implementacija
{
    public class StorageIznajmljivanjeSqlServer : IStorageIznajmljivanje
    {
        private Broker broker = new Broker();
        public void DodajIznajmljivanje(Iznajmljivanje i)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    broker.DodajIznajmljivanje(i);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }
    }
}
