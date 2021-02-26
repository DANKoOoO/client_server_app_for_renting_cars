using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorkerBP;
using Domen;

namespace Storage.Implementacija
{
    public class StorageAutomobilSqlServer : IStorageAutomobil
    {
        private Broker broker = new Broker();
        public void DodajAutomobil(Automobil a)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    a.ID = broker.VratiAutomobilID();
            //    a.Stanje = Stanja.uGarazi;
            //    broker.DodajAutomobil(a);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public void IzmeniAutomobil(Automobil a)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    broker.IzmeniAutomobil(a);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public void ObrisiAutomobil(List<Automobil> listaZaBrisanje)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    broker.UkloniAutomobile(listaZaBrisanje);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public List<Automobil> VratiSveAutomobile()
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    return broker.SviAutomobili();
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
            return null;
        }
    }
}
