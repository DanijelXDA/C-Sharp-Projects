using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokusaji = 0; // Broj pokusaja je max 3
            int dan, mesec, godina;

            // Unos dana i provera limita
            do
            {
                Console.Write("Unesite dan: ");
                dan = Convert.ToInt32(Console.ReadLine());

                if (dan <= 0 || dan > 31)
                {
                    pokusaji++;

                    if (pokusaji == 3)
                        Console.WriteLine("Iskoriscen je maximalan broj pokusaja... Go and die xD");
                    else
                        Console.WriteLine("Unos nije validan! Broj preostalih pokusaja: {0}", 3 - pokusaji);
                }
                else
                    break;

            } while (pokusaji < 3);

            // Unos meseca i provera limita
            do
            {
                Console.Write("Unesite mesec: ");
                mesec = Convert.ToInt32(Console.ReadLine());

                if (mesec <= 0 || mesec > 12)
                {
                    pokusaji++;

                    if (pokusaji == 3)
                        Console.WriteLine("Iskoriscen je maximalan broj pokusaja... Go and die xD");
                    else
                        Console.WriteLine("Unos nije validan! Broj preostalih pokusaja: {0}", 3 - pokusaji);
                }
                else
                    break;

            } while (pokusaji < 3);

            // Unos godine i provera limita
            do
            {
                Console.Write("Unesite godinu: ");
                godina = Convert.ToInt32(Console.ReadLine());

                if (godina <= 1970 || godina > 2010)
                {
                    pokusaji++;

                    if (pokusaji == 3)
                        Console.WriteLine("Iskoriscen je maximalan broj pokusaja... Go and die xD");
                    else
                        Console.WriteLine("Unos nije validan! Broj preostalih pokusaja: {0}", 3 - pokusaji);
                }
                else
                    break;

            } while (pokusaji < 3);
            // KRAJ UNOSA //


            // Provera ispisa
            // Console.WriteLine("Dan = {0}, Mesec = {1}, Godina = {2}", dan, mesec, godina);

            // OBRADA PODATAKA //
            switch (mesec)
            {
                // Meseci koji imaju 31 dan!
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if (dan == 31 && mesec == 12)
                        { // Ako je 31. decembar 
                            dan = 1;                   // setujemo dan na prvi
                            godina++;                   // godinu prebacujemo na sledecu
                            mesec = 1;                 // Mesec ide na januar
                        }
                        else if (dan > 31) // Nije decembar ali je 31. dan u mesecu
                        {
                            dan = 1;      // Prvi dan sledeceg meseca
                            mesec++;      // Prebacujemo se na sledeci mesec
                        }
                        else // Dan nije 31. decembar i manji je od toga
                            dan++;        // Samo dan uvecamo za 1

                        break; // Sprecavanje programskog propadanja!

                    }
                // Meseci koji imaju 30 dana!
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (dan == 30) // 30. dan u mesecu
                        {
                            dan = 1;      // Prvi dan sledeceg meseca
                            mesec++;      // Prebacujemo se na sledeci mesec
                        }
                        else // Dan nije 30. u mesecu (manji je od toga)
                            dan++;        // Samo dan uvecamo za 1

                        break; // Sprecavanje programskog propadanja!
                    }
                case 2:
                    {
                        if (dan == 28 && prestupnaGodina(godina)) // Prestupna godina -> Postoji 29. februar
                            dan++;
                        else if (dan <= 27)
                            dan++;

                        // Ako je uneta prestupna godina i 29. februar
                        if (dan == 29 && prestupnaGodina(godina))
                        {
                            dan = 1; // Setovanje na prvi
                            mesec = 3; // Mart
                        }


                        break; // Sprecavanje programskog propadanja!
                    }
            }

            Console.WriteLine(); // Prelazak u novi red

            // Provera validnosti datuma //
            // Provera se vrsi jer moze da se unese 30. februar -> Zastitni modul v2.05.3
            if ((dan == 29 || dan == 30 || dan == 31) && mesec == 2 && !(prestupnaGodina(godina)))
                Console.WriteLine("Uneti datum: {0}.{1}.{2}. NIJE VALIDAN!", dan, mesec, godina);
            else if ((dan == 30 || dan == 31) && mesec == 2 && prestupnaGodina(godina))
                Console.WriteLine("Uneti datum: {0}.{1}.{2}. NIJE VALIDAN!", dan, mesec, godina);
            else // Datum je validan -> Ispisi ga
                Console.WriteLine("Datum: {0}.{1}.{2}.", dan, mesec, godina);

            Console.ReadKey();

        }
        public static bool prestupnaGodina(int godina)  // Funkcija koja proverava da li je uneta godina prestupna
        {
            if (godina % 400 == 0 || godina % 100 != 0 && godina % 4 == 0) // Prestupna godina
                return true;
            else   // Nije prestupna
                return false;
        }

    }
}
