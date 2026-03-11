using System;
using System.Collections.Generic;
using System.Text;

namespace Praktilised_ulesanded_Failitootlus_ja_Listid
{
    internal class StartPage
    {
        public static void Main(string[] args)
        {
            bool tööta = true;
            while (tööta)
            {
                Console.WriteLine("1.  Lemmiktoidu salvestamine faili");
                Console.WriteLine("2.  Kogu menüü kuvamine");
                Console.WriteLine("3.  Koostisosade muutmine nimekirjas");
                Console.WriteLine("4. Kulmkapi Kontroll ");
                Console.WriteLine("5. Salvesta Uuendatud Nimekiri");
                Console.WriteLine("6. Itaalia Restoran");
                Console.WriteLine("Vali funktsioon");
                string valik = Console.ReadLine();
                Console.WriteLine();
                switch (valik)
                {
                    case "1":
                        Ulesanded.Lemmiktoit();
                        break;
                    case "2":
                        Ulesanded.KoguMenu();
                        break;
                    case "3":
                        List<string> Koostisosad = new List<string>();
                        Ulesanded.Koostisosade_muutmine();
                        break;
                    case "4":
                        Ulesanded.KulmkapiKontroll();
                        break;
                    case "5":
                        Ulesanded.SalvestaUuendatudNimekiri();
                        break;
                    case "6":
                        Ulesanded.ItaaliaRestoran();
                        break;

                }
            }
        }
    }
}
