﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Odgovor
    {
        public bool Uspesno { get; set; }

        public object Objekat { get; set; }

        public string Error { get; set; }
    }
}
