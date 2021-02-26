using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Ocena : IEntity
    {
        public int ClanID { get; set; }

        public int AutomobilID { get; set; }
        // ocena od 0 do 5
        public int OcenaNumericka { get; set; }

        public string Opis { get; set; }

        public string Tablename { get { return "Ocena"; } }

        public string InsertValues => $"{ClanID}, {AutomobilID}, {OcenaNumericka}, '{Opis}'";

        public string IdNaziv => throw new NotImplementedException();

        public string JoinTable => "";

        public string JoinCondition => "";

        public string SelectColumns => "*";

        public string TableAlias => "o";

        public string WhereClause => "";

        public string WhereClause1 => "";

        public string SetColumn => "";

        public string WhereClause2 => "";

        public string ChildTable => "";

        public string ChildInsertValues => "";

        public string ChildJoinTable => throw new NotImplementedException();

        public string ChildJoinCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Ocena
                {
                    AutomobilID = (int)reader["AutomobilID"],
                    ClanID = (int)reader["KorisnikID"],
                    OcenaNumericka = (int)reader["Ocena"],
                    Opis = (string)reader["Opis"]
                }
                );

            }
            return entities;
        }
    }
}
