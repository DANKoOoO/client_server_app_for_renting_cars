using Common;
using Controller;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        private BindingList<Korisnik> korisnici = new BindingList<Korisnik>();

        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"])));
        }
        public void Listen()
        {
            listener.Listen(5);
            try
            {
                while (true)
                {
                    Socket klijent = listener.Accept();
                    ClientHandler clientHandler = new ClientHandler(klijent,korisnici);
                    klijenti.Add(clientHandler);
                    Thread thread = new Thread(clientHandler.StartHandeler);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Kraj rada! "+ex.Message);
            }
        }

        internal void Stop()
        {
            listener.Close();
            foreach(ClientHandler ch in klijenti)
            {
                ch.Stop();
            }
            klijenti.Clear();
        }

        public BindingList<Korisnik> Korisnici
        {
            get { return korisnici; }
        }
    }
}
