using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1___Fudbalski_klub
{
    class Fudbaler
    {
        // NAPOMENA MENI: NE TREBAJU MI PRIVATNA POLJA U KLASI xD
        public enum PozicijaFudbalera { GOLMAN, ODBRANA, SREDINA, NAPAD };

        public int BrDresa { get ; set ; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public PozicijaFudbalera Pozicija { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public Fudbaler(int brDresa, string ime, string prezime, DateTime datumRodjenja, PozicijaFudbalera po)
        {
            BrDresa = brDresa;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }
    }
}