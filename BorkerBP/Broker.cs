using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkerBP
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RentACarDatabase"].ConnectionString);
        }

        public void ZapocniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void ZapocniKonekciju()
        {
            connection.Open();
        }

        public void ZavrsiKonekciju()
        {
            connection.Close();
        }
        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }
        public int VratiID(IEntity entity)
        {
            object result = 0;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.IdNaziv}) from {entity.Tablename}";

            result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result + 1;
            }
        }

        public void DodajSaNasledjivanjem(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.Tablename} values ({entity.InsertValues})";
            command.ExecuteNonQuery();
            command.CommandText = $"insert into {entity.ChildTable} values ({entity.ChildInsertValues})";
            command.ExecuteNonQuery();
        }

        public void Dodaj(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.Tablename} values ({entity.InsertValues})";
            command.ExecuteNonQuery();
        }

        public List<IEntity> VratiSve(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectColumns} from {entity.Tablename} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }
      
        public List<IEntity> VratiOdredjene(IEntity entity, string pocetnaSlova)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectColumns} from {entity.Tablename} {entity.TableAlias} {entity.ChildJoinTable} {entity.ChildJoinCondition} {entity.WhereClause1} '%{pocetnaSlova}%'";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public void Izmeni(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {entity.Tablename} set {entity.SetColumn} {entity.WhereClause2}";
            command.ExecuteNonQuery();
        }

        public void Ukloni(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from {entity.Tablename} {entity.WhereClause2}";
            command.ExecuteNonQuery();
        }




        //public List<IEntity> VratiOdredjene(IEntity entity, string pocetnaSlova)
        //{
        //    List<IEntity> result;
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = $"select {entity.SelectColumns} from {entity.Tablename} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.WhereClause1} '%{pocetnaSlova}%'";
        //    SqlDataReader reader = command.ExecuteReader();
        //    result = entity.GetEntities(reader);
        //    reader.Close();
        //    return result;
        //}

        //public void DodajIznajmljivanje(Iznajmljivanje i)
        //{
        //    object result;
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = "select max(id) from Iznajmljivanje";

        //    result = command.ExecuteScalar();
        //    if (result is DBNull)
        //    {
        //        result = 1;
        //    }
        //    else
        //    {
        //        result = (int)result + 1;
        //    }
        //    command.CommandText = $"insert into Iznajmljivanje values(@id, @clanID, @automobilID, @datumPocetka, @datumKraja, @adminID)";
        //    command.Parameters.AddWithValue("@id", (int)result);
        //    command.Parameters.AddWithValue("@clanID", i.ClanID);
        //    command.Parameters.AddWithValue("@automobilID", i.AutomobilID);
        //    command.Parameters.AddWithValue("@datumPocetka", i.DatumPocetka);
        //    command.Parameters.AddWithValue("@datumKraja", i.DatumKraja);
        //    command.Parameters.AddWithValue("@adminID", i.AdminID);

        //    command.ExecuteNonQuery();
        //}

        //public void IzmeniAutomobil(Automobil a)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"update Automobil set Stanje = {(int)a.Stanje} where id = {a.ID}";
        //    command.ExecuteNonQuery();
        //}

        //public void DodajOcenu(Ocena o)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"insert into Ocena values (@korisnikID, @automobilID, @ocena, @opis)";
        //    command.Parameters.AddWithValue("@korisnikID", o.ClanID);
        //    command.Parameters.AddWithValue("@automobilID", o.AutomobilID);
        //    command.Parameters.AddWithValue("@ocena", o.OcenaNumericka);
        //    command.Parameters.AddWithValue("@opis", o.Opis);

        //    command.ExecuteNonQuery();
        //}

        //public void UkloniAutomobile(List<Automobil> listaZaBrisanje)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    foreach (Automobil a in listaZaBrisanje)
        //    {
        //        command.CommandText = $"delete from Automobil where id = {a.ID}";
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void DodajAutomobil(Automobil a)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"insert into Automobil values (@id, @registracija, @stanje, @marka, @model, @kubikaza)";
        //    command.Parameters.AddWithValue("@id", a.ID);
        //    command.Parameters.AddWithValue("@registracija", a.Registracija);
        //    command.Parameters.AddWithValue("@stanje", a.Stanje);
        //    command.Parameters.AddWithValue("@marka", a.Marka);
        //    command.Parameters.AddWithValue("@model", a.Model);
        //    command.Parameters.AddWithValue("@kubikaza", a.Kubikaza);

        //    command.ExecuteNonQuery();
        //}

        //public List<Korisnik> VratiClanoveSaPocetnimSlovima(string pocetnaSlova)
        //{
        //    List<Korisnik> korisnici = new List<Korisnik>();
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"select * from Korisnik k join Clan c on(k.id = c.ClanID) where k.Ime like '%{pocetnaSlova}%' or k.Prezime like '%{pocetnaSlova}%'";
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Clan clan = new Clan
        //        {
        //            ID = (int)reader["id"],
        //            KorisnickoIme = (string)reader["KorisnickoIme"],
        //            Lozinka = (string)reader["Lozinka"],
        //            Ime = (string)reader["Ime"],
        //            Prezime = (string)reader["Prezime"],
        //            Tip = false,
        //            FizickoPravno = (string)reader["FizickoPravno"],
        //            Status = (string)reader["Status"]
        //        };
        //        korisnici.Add(clan);
        //    }
        //    reader.Close();
        //    return korisnici;
        //}

        //public List<Korisnik> VratiSveClanove()
        //{
        //    List<Korisnik> korisnici = new List<Korisnik>();
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = "select * from Korisnik k join Clan c on(k.id = c.ClanID)";
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Clan clan = new Clan
        //        {
        //            ID = (int)reader["id"],
        //            KorisnickoIme = (string)reader["KorisnickoIme"],
        //            Lozinka = (string)reader["Lozinka"],
        //            Ime = (string)reader["Ime"],
        //            Prezime = (string)reader["Prezime"],
        //            Tip = false,
        //            FizickoPravno = (string)reader["FizickoPravno"],
        //            Status = (string)reader["Status"]
        //        };
        //        korisnici.Add(clan);
        //    }
        //    reader.Close();
        //    return korisnici;
        //}

        //public List<Automobil> SviAutomobili()
        //{
        //    List<Automobil> automobili = new List<Automobil>();
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = "select * from Automobil";
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Automobil a = new Automobil
        //        {
        //            ID = (int)reader["id"],
        //            Registracija = (string)reader["Registracija"],
        //            Marka = (string)reader["Marka"],
        //            Model = (string)reader["Model"],
        //            Kubikaza = (int)reader["Kubikaza"],
        //            Stanje = (Stanja)reader["Stanje"]
        //        };
        //        automobili.Add(a);
        //    }
        //    return automobili;
        //}

        //public int VratiAutomobilID()
        //{
        //    object result = 0;
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = "select max(id) from Automobil";

        //    result = command.ExecuteScalar();
        //    if (result is DBNull)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return (int)result + 1;
        //    }
        //}

        //public int VratiKorisnikID()
        //{
        //    object result = 0;
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = "select max(id) from Korisnik";

        //    result = command.ExecuteScalar();
        //    if (result is DBNull)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return (int)result + 1;
        //    }
        //}

        //public void DodajClana(Clan k)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"insert into Clan values(@clanID, @status, @fizickoPravno)";
        //    command.Parameters.AddWithValue("@clanID", k.ID);
        //    command.Parameters.AddWithValue("@status", k.Status); 
        //    command.Parameters.AddWithValue("@fizickoPravno", k.FizickoPravno);


        //    command.ExecuteNonQuery();
        //}

        //public void DodajAdmina(Admin k)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"insert into Admin values(@adminid, @pozicija, @brojIznajmljivanja, @ocena, @naPoslu)";
        //    command.Parameters.AddWithValue("@adminid", k.ID);
        //    command.Parameters.AddWithValue("@pozicija", k.Pozicija);
        //    command.Parameters.AddWithValue("@brojIznajmljivanja", 0);
        //    command.Parameters.AddWithValue("@ocena", 0.0);
        //    command.Parameters.AddWithValue("@naPoslu", false);

        //    command.ExecuteNonQuery();
        //}

        //public void DodajKorisnika(Korisnik k)
        //{
        //    SqlCommand command = new SqlCommand("", connection, transaction);
        //    command.CommandText = $"insert into Korisnik values(@id, @korisnickoIme, @lozinka, @ime, @prezime, @tip)";
        //    command.Parameters.AddWithValue("@id", k.ID);
        //    command.Parameters.AddWithValue("@korisnickoIme", k.KorisnickoIme);
        //    command.Parameters.AddWithValue("@lozinka", k.Lozinka);
        //    command.Parameters.AddWithValue("@ime", k.Ime);
        //    command.Parameters.AddWithValue("@prezime", k.Prezime);
        //    command.Parameters.AddWithValue("@tip", k.Tip);

        //    command.ExecuteNonQuery();

        //}

        //public List<Korisnik> SviKorisnici()
        //{
        //    List<Korisnik> korisnici = new List<Korisnik>();
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = "select * from Korisnik k join Admin a on(k.id = a.AdminID)";
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Admin admin = new Admin
        //        {
        //            ID = (int)reader["id"],
        //            KorisnickoIme = (string)reader["KorisnickoIme"],
        //            Lozinka = (string)reader["Lozinka"],
        //            Ime = (string)reader["Ime"],
        //            Prezime = (string)reader["Prezime"],
        //            Tip = true,
        //            Pozicija = (string)reader["Pozicija"],
        //            BrojIznajmljivanja = (int)reader["BrojIznajmljivanja"],
        //            Ocena = (double)reader["Ocena"],
        //            NaPoslu = true
        //        };
        //        korisnici.Add(admin);
        //    }
        //    reader.Close();
        //    command.CommandText = "select * from Korisnik k join Clan c on(k.id = c.ClanID)";
        //    reader = command.ExecuteReader();
        //    while (reader.Read())            {
        //        Clan clan = new Clan
        //        {
        //            ID = (int)reader["id"],
        //            KorisnickoIme = (string)reader["KorisnickoIme"],
        //            Lozinka = (string)reader["Lozinka"],
        //            Ime = (string)reader["Ime"],
        //            Prezime = (string)reader["Prezime"],
        //            Tip = false,
        //            FizickoPravno = (string)reader["FizickoPravno"],
        //            Status = (string)reader["Status"]
        //        };
        //        korisnici.Add(clan);
        //    }
        //    reader.Close();
        //    return korisnici;
        //}
    }

}
