﻿using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sender
    {
        private readonly Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            this.formatter = new BinaryFormatter();
        }

        public void Send(Zahtev zahtev)
        {
            try
            {
                formatter.Serialize(stream, zahtev);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch (SocketException ex)
            {
                throw new ServerException(ex.Message);
            }
        }
    }
}
