using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Automobil : IEntity
    {
        public int ID { get; set; }

        public string Registracija { get; set; }
        
        public Stanja Stanje { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public double Kubikaza { get; set; }

        public string Tablename => "Automobil";

        public string InsertValues => $"'{Registracija}', {(int)Stanje}, '{Marka}', '{Model}', {Kubikaza}";

        public string IdNaziv => "id";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string SelectColumns => "*";

        public string TableAlias => "au";

        public string WhereClause1 => "";

        public string SetColumn => $"Stanje = {(int)Stanje}";

        public string WhereClause2 => $"where id = {ID}";

        public string ChildTable => "";

        public string ChildInsertValues => "";

        public string ChildJoinTable => "";

        public string ChildJoinCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Automobil
                {
                    ID = (int)reader["id"],
                    Registracija = (string)reader["Registracija"],
                    Stanje = (Stanja)reader["Stanje"],
                    Marka = (string)reader["Marka"],
                    Model = (string)reader["Model"],
                    Kubikaza = (int)reader["Kubikaza"]
                }
                );

            }
            return entities;
        }
    }
}
