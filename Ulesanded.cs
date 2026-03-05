using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;



    public class Ulesanded
    {
         
        public static void Lemmiktoit()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamWriter text = new StreamWriter(path, true);
                Console.WriteLine("Sisesta ühte Itaalia toidu nime:");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Mingi viga failiga");
            }
            
        }
        public static void KoguMenu()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {

                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static List<string> Koostisosade_muutmine()
        {
            List<string> Koostisosad = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    Koostisosad.Add(rida);
                }
               
                
                if (Koostisosad.Count > 0)
                    Koostisosad[0] = "Kvaliteetne oliiviõli";
                
                Koostisosad.Remove("Ketšup");
                foreach (string item in Koostisosad)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga!");
            }
            return Koostisosad;
        }




    }



