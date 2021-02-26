using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorkerBP;
using Domen;

namespace Storage.Implementacija
{
    public class StorageOcenaSqlServer : IStorageOcena
    {
        private Broker broker = new Broker();
        public void DodajOcenu(Ocena o)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    broker.DodajOcenu(o);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public double VratiProsecnuOcenu(Automobil a)
        {
            throw new NotImplementedException();
        }
    }
}
