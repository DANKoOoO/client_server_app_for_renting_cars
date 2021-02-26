using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Admin : Korisnik
    {
        public string Pozicija { get; set; }

        public int BrojIznajmljivanja { get; set; }

        public double Ocena { get; set; }

        public bool NaPoslu { get; set; }

        public new string Tablename => "Admin";

        public new string InsertValues => $"{ID}, '{Pozicija}', {BrojIznajmljivanja}, {Ocena}, {NaPoslu}";

        public new string IdNaziv => "AdminID";
        public new string JoinTable => "join Korisnik k";

        public new string JoinCondition => "on (a.AdminID = k.id)";

        public new string SelectColumns => "a.AdminID aid, a.Pozicija apoz, a.BrojIznajmljivanja abriz, a.Ocena aocena, a.NaPoslu anaposlu, k.id kid, k.KorisnickoIme kkorime, k.Lozinka klozinka, k.Ime kime, k.Prezime kprezime, k.tip ktip";

        public new string TableAlias => "a";

        public new string WhereClause1 => "";

        public override string ChildTable => "Admin";

        public override string ChildInsertValues => $"{ID}, '{Pozicija}', {BrojIznajmljivanja}, {Ocena}, '{NaPoslu}'";

        public new List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Admin
                {
                    ID = (int)reader["kid"],
                    KorisnickoIme = (string)reader["kkorime"],
                    Lozinka = (string)reader["klozinka"],
                    Ime = (string)reader["kime"],
                    Prezime = (string)reader["kprezime"],
                    Tip = (bool)reader["ktip"],
                    Pozicija = (string)reader["apoz"],
                    BrojIznajmljivanja = (int)reader["abriz"],
                    Ocena = (double)reader["aocena"],
                    NaPoslu = (bool)reader["anaposlu"]
                }
                );

            }
            return entities;
        }
    }
}
