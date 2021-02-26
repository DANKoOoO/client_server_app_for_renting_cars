using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public abstract class Korisnik : IEntity
    {
        public int ID { get; set; }

        public string KorisnickoIme { get; set; }

        public string Lozinka { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }
        // true za admina, false za Clana
        public bool Tip { get; set; }

        public virtual string Tablename => "Korisnik";

        public virtual string InsertValues => $"{ID}, '{KorisnickoIme}', '{Lozinka}', '{Ime}', '{Prezime}', '{Tip}'";

        public virtual string IdNaziv => "id";

        public virtual string JoinTable => "";

        public virtual string JoinCondition => "";

        public virtual string SelectColumns => "*";

        public virtual string TableAlias => "k";

        public virtual string WhereClause1 => "";

        public virtual string SetColumn => "";

        public virtual string WhereClause2 => "";

        public virtual string ChildTable => throw new NotImplementedException();

        public virtual string ChildInsertValues => throw new NotImplementedException();

        public virtual string ChildJoinTable => throw new NotImplementedException();

        public virtual string ChildJoinCondition => throw new NotImplementedException();

        public virtual List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                if ((bool)reader["tip"])
                {
                    entities.Add(new Admin
                    {
                        ID = (int)reader["id"],
                        KorisnickoIme = (string)reader["KorisnickoIme"],
                        Lozinka = (string)reader["Lozinka"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Tip = (bool)reader["tip"],

                    }
                    );
                }
                else
                {
                    entities.Add(new Clan
                    {
                        ID = (int)reader["id"],
                        KorisnickoIme = (string)reader["KorisnickoIme"],
                        Lozinka = (string)reader["Lozinka"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Tip = (bool)reader["tip"],
                    }
                   );
                }
            }
            return entities;
        }
    }
}
