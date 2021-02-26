using BorkerBP;
using Domen;
using Storage;
using Storage.Implementacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class SystemOperationBase
    {
        //protected Broker broker = new Broker();
        //public object Rezultat { get; protected set; }
        protected IGenericRepository repository;
        public SystemOperationBase()
        {
            repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity, object parametri)
        {
            try
            {
                repository.ZapocniKonekciju();
                Izvrsi(entity, parametri);
                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw ex;
            }
            finally
            {
                repository.ZavrsiKonekciju();
            }
        }
        protected abstract void Izvrsi(IEntity entity, object parametri);
    }
}
