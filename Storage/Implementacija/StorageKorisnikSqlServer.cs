using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorkerBP;
using Domen;

namespace Storage.Implementacija
{
    public class StorageKorisnikSqlServer : IStorageKorisnik
    {
        private Broker broker = new Broker();
        public List<Korisnik> SviKorisnici()
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    return broker.SviKorisnici();
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
            return null;
        }

        public void DodajAdmina(Korisnik k)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    k.ID = broker.VratiKorisnikID();
            //    broker.DodajKorisnika(k);
            //    broker.DodajAdmina((Admin)k);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public void DodajClana(Korisnik k)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    k.ID = broker.VratiKorisnikID();
            //    broker.DodajKorisnika(k);
            //    broker.DodajClana((Clan)k);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
        }

        public string KorisnikID()
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    return "" + broker.VratiKorisnikID();
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
            return null;
        }

        public List<Korisnik> VratiSveClanove()
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    return broker.VratiSveClanove();
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
            return null;
        }

        public List<Korisnik> VratiClanoveSaPocetnimSlovima(string pocetnaSlova)
        {
            //try
            //{
            //    broker.ZapocniKonekciju();
            //    return broker.VratiClanoveSaPocetnimSlovima(pocetnaSlova);
            //}
            //finally
            //{
            //    broker.ZavrsiKonekciju();
            //}
            return null;
        }
    }
}
