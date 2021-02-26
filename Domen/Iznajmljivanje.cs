using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Iznajmljivanje : IEntity
    {
        public int ClanID { get; set; }

        public int AutomobilID { get; set; }

        public DateTime DatumPocetka { get; set; }

        public DateTime DatumKraja { get; set; }

        public int AdminID { get; set; }

        public string Tablename => "Iznajmljivanje";

        public string InsertValues => $"{ClanID}, {AutomobilID}, '{DatumPocetka.ToString("yyyy-MM-dd")}', '{DatumKraja.ToString("yyyy-MM-dd")}', {AdminID}";

        public string IdNaziv => "id";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string SelectColumns => "*";

        public string TableAlias => "";

        public string WhereClause => "";

        public string WhereClause1 => "";

        public string SetColumn => "";

        public string WhereClause2 => "";

        public string ChildTable => throw new NotImplementedException();

        public string ChildInsertValues => throw new NotImplementedException();

        public string ChildJoinTable => throw new NotImplementedException();

        public string ChildJoinCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Iznajmljivanje
                {
                    AdminID = (int)reader["AdminID"],
                    AutomobilID = (int)reader["AutomobilID"],
                    ClanID = (int)reader["ClanID"],
                    DatumPocetka = (DateTime)reader["DatumPocetka"],
                    DatumKraja = (DateTime)reader["DatumKraja"]
                }
                );

            }
            return entities;
        }
    }
}
