/*
Napraviti klasu Racun koja u sebi sadrzi polja broj racuna tipa string, ime korisnika tipa string,
sredstva na racunu tipa double, dozvoljeni minus tipa double. Napraviti program koji omogucava
korisniku da moze da skine pare sa racuna, da moze da uplati pare na racun.Voditi racuna da
ukoliko korisnik nema dovoljno para na racunu da racun moze da udje u dozvoljeni minus koji je
definisan poljem dozvoljeni minus.Korisniku ne treba dozvoliti da moze da skine vise para nego sto
mu dozvoljava polje dozvoljeni minus.Korisnik nema pravo da menja ovo polje. 
*/
using System;

namespace racunUBanci
{
    class Racun
    {
        private string brojRacuna;
        private string imeKorisnika;
        private double sredstvaNaRacunu;
        private double dozvoljeniMinus;

        //konstruktor
        public Racun()
        {
            brojRacuna = "12345678";
            imeKorisnika = "Korisnik";
            sredstvaNaRacunu = 1000;
            dozvoljeniMinus = 500;
        }
        // metode SETERI
        public void setDozvoljeniMinus(double dozMinus)
        {
            dozvoljeniMinus = dozMinus;
        }
        public void setImeKorisnika(string ime)
        {
            imeKorisnika = ime;
        }
        public void setBrojRacuna(string brRacuna)
        {
            brojRacuna = brRacuna;
        }
        // metode GETERI
        public string getImeKorisnika()
        {
            return imeKorisnika;
        }
        public string getBrojRacuna()
        {
            return brojRacuna;
        }
        public double getStanjeNaRacunu()
        {
            return sredstvaNaRacunu;
        }
        public double getDozvoljeniMinus()
        {
            return dozvoljeniMinus;
        }
        // podizanje para
        public bool podizanjePara(double iznosZaPodizanje)
        {
            double novoStanje = sredstvaNaRacunu - iznosZaPodizanje; // nakon podizanja
            if (novoStanje > -dozvoljeniMinus )
            {
                sredstvaNaRacunu -= iznosZaPodizanje;
                return true; // podizanje novca uspesno
            }
            else
                return false;
        }
        // uplata na racun
        public bool uplataNaRacun(double iznos)
        {
            if (iznos > 0)
            {
                sredstvaNaRacunu += iznos;
                return true; // uplata novca uspesno
            }
            else
                return false;
        }
    }
}
