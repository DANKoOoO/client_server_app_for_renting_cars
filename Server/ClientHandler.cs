using Common;
using Controller;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijent;
        private readonly BindingList<Korisnik> korisnici;
        private bool kraj;
        Korisnik korisnik;
        public ClientHandler(Socket klijent, BindingList<Korisnik> korisnici)
        {
            this.klijent = klijent;
            this.korisnici = korisnici;
            kraj = false;
        }
        public void StartHandeler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(klijent);
                BinaryFormatter formatter = new BinaryFormatter();
                
                while (!kraj)
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor = ProcesuirajZahtev(zahtev);
                    formatter.Serialize(stream, odgovor);
                }
            }catch(IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private Odgovor ProcesuirajZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            switch (zahtev.Operacija)
            {
                case Operacija.PrijaviKorisnika:
                    korisnik = Kontroler.Instance.PrijaviKorisnika(zahtev.KorisnickoIme, zahtev.Lozinka);                  
                    if (korisnik != null)
                    {
                        odgovor.Uspesno = true;
                        odgovor.Objekat = korisnik;
                        korisnici.Add(korisnik);
                    }
                    else
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = "Ne postoji taj korisnik";
                    }
                    break;
                case Operacija.VratiSveAutomobile:
                    try
                    {
                        odgovor.Objekat = Kontroler.Instance.VratiSveAutomobile();
                        odgovor.Uspesno = true;
                    }catch(Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;

                    }
                    break;
                case Operacija.VratiAutomobileSaOdredjenimParametrima:
                    try
                    {
                        odgovor.Objekat = Kontroler.Instance.VratiAutomobileSaOdredjenimParametrima((Automobil)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.UkloniAutomobile:
                    try
                    {
                        Kontroler.Instance.UkloniAutomobile((List<Automobil>)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.DodajAutomobil:
                    try
                    {
                        Kontroler.Instance.DodajAutomobil((Automobil)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.VratiID:
                    try
                    {
                        odgovor.Objekat = Kontroler.Instance.VratiID();
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.DodajAdmina:
                    try
                    {
                        Kontroler.Instance.DodajAdmina((Admin)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.DodajClana:
                    try
                    {
                        Kontroler.Instance.DodajClana((Clan)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.IzmeniStanjeAutomobila:
                    try
                    {
                        Kontroler.Instance.IzmeniStanjeAutomobila((List<Automobil>)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.DodajOcenu:
                    try
                    {
                        Kontroler.Instance.DodajOcenu((Ocena)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.VratiSveClanove:
                    try
                    {
                        odgovor.Objekat = Kontroler.Instance.VratiSveClanove();
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.VratiClanoveSaPocetnimSlovima:
                    try
                    {
                        odgovor.Objekat = Kontroler.Instance.VratiClanaSaPocetnimSlovima((string)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.DodajIznajmljivanje:
                    try
                    {
                        Kontroler.Instance.DodajIznajmljivanje((List<Iznajmljivanje>)zahtev.Objekat);
                        odgovor.Uspesno = true;
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
                case Operacija.PrekiniKonekciju:
                    try
                    {
                        kraj = true;
                        odgovor.Uspesno = true;
                        korisnici.Remove(korisnik);
                    }
                    catch (Exception ex)
                    {
                        odgovor.Uspesno = false;
                        odgovor.Error = ex.Message;
                    }
                    break;
            }
            return odgovor;
        }

        internal void Stop()
        {
            klijent.Close();
        }
    }
}
