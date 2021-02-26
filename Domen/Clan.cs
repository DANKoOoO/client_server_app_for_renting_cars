using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clan : Korisnik
    {
        public string Status { get; set; }

        // da li je fizicko lice ili pravno lice
        public string FizickoPravno { get; set; }

        public new string Tablename => "Clan";

        public new string InsertValues => $"{ID}, 'nov', '{FizickoPravno}'";

        public new string IdNaziv => "ClanID";

        public new string JoinTable => "join Korisnik k";

        public new string JoinCondition => "on (c.ClanID = k.id)";

        public new string SelectColumns => "c.ClanID cid, c.Status cstat, c.FizickoPravno cfizpr, k.id kid, k.KorisnickoIme kkorime, k.Lozinka klozinka, k.Ime kime, k.Prezime kprezime, k.tip ktip";
        public new string TableAlias => "c";
        public override string WhereClause1 => "where (k.Ime + k.Prezime) like";
        // public override string WhereClause1 => "where k.Ime like '%";
        // public override string WhereClasue2 => "%' or k.Prezime like '%";
        // public override string WhereClasue3 => "%'";
        public override string ChildTable => "Clan";
        public override string ChildInsertValues => $"{ID}, 'nov', '{FizickoPravno}'";
        public override string ChildJoinTable => "join Clan c";
        public override string ChildJoinCondition => "on (c.ClanID = k.id)";


        public new List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Clan
                {
                    ID = (int)reader["kid"],
                    KorisnickoIme = (string)reader["kkorime"],
                    Lozinka = (string)reader["klozinka"],
                    Ime = (string)reader["kime"],
                    Prezime = (string)reader["kprezime"],
                    Tip = (bool)reader["ktip"],
                    Status = (string)reader["cstat"],
                    FizickoPravno = (string)reader["cfizpr"]
                }
                );

            }
            return entities;
        }
    }
}
