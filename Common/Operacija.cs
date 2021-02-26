using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum Operacija
    {
        PrijaviKorisnika, 
        DodajIznajmljivanje, 
        DodajOcenu, 
        DodajAutomobil, 
        DodajClana, 
        DodajAdmina, 
        UkloniAutomobile, 
        IzmeniStanjeAutomobila, 
        VratiSveAutomobile, 
        VratiAutomobileSaOdredjenimParametrima, 
        VratiSveClanove, 
        VratiClanoveSaPocetnimSlovima, 
        VratiID, 

        PrekiniKonekciju 
    }
}
