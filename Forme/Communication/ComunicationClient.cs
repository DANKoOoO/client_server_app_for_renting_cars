using Common;
using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Communication
{
    public class ComunicationClient
    {
        private Receiver receiver;
        private Sender sender;

        public ComunicationClient(Socket soket)
        {
            receiver = new Receiver(soket);
            sender = new Sender(soket);
        }

        public void PosaljiZahtev(Zahtev zahtev)
        {
            try
            {
                sender.Send(zahtev);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch(SocketException ex)
            {
                throw new ServerException(ex.Message);
            }
        }

        public object PrimiOdgovor()
        {
            Odgovor odgovor = (Odgovor)receiver.Recieve();
            if (odgovor.Uspesno)
            {
                return odgovor.Objekat;
            }
            else
            {
                throw new SystemOperationException(odgovor.Error);
            }
        }
    }
}
