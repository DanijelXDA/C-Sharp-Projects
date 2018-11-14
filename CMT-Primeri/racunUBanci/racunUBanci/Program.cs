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
    class Program
    {
        static void Main(string[] args)
        {
            Racun r = new Racun();

            Console.Write("Unesite koliko novca bi da podignete: ");
            double podizanje = double.Parse(Console.ReadLine());

            r.setImeKorisnika("Danijel");
            r.setBrojRacuna("00364856FQ6");
            r.setDozvoljeniMinus(5000);
            r.uplataNaRacun(7500.75);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pokretanje transakcije...... ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Korisnik: " + r.getImeKorisnika());
            Console.WriteLine("Broj racuna: " + r.getBrojRacuna());
            Console.WriteLine("Sredstva na racunu: " + r.getStanjeNaRacunu());
            Console.WriteLine("Dozvoljeni minus: " + r.getDozvoljeniMinus());

            if (r.podizanjePara(podizanje))
            {
                Console.WriteLine();
                Console.WriteLine("Novac uspesno podignut!");
                Console.WriteLine();
                Console.WriteLine("Sredstva na racunu: " + r.getStanjeNaRacunu());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Novac nije uspesno podignut!");
                Console.WriteLine();
                Console.WriteLine("Sredstva na racunu: " + r.getStanjeNaRacunu());
            }
            Console.ReadKey();

        }
    }
}
