using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageOFwar.Personaggi
{
    public class Cavaliere:Personaggio
    {
        public Cavaliere(int Puntiforza)
        {
            PuntiVita = 1000;
            PuntiForza += Puntiforza;
        }
    }
}
