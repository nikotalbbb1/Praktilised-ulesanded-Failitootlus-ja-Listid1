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
                Console.WriteLine("1.  Pinginaabrid");
                Console.WriteLine("2.  Kogu menüü kuvamine");
                Console.WriteLine("3.  Koostisosade muutmine nimekirjas");

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
                        Ulesanded.Koostisosade_muutmine();
                        break;

                }
        }
    }
}
