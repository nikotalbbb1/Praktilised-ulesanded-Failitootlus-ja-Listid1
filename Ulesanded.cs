using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;



public class Ulesanded
{


    public static void Lemmiktoit()
    {
        string Retpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

        try
        {
            Retpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
            StreamWriter text = new StreamWriter(Retpath, true);
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
        string Retpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
        try
        {
            Retpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
            StreamReader text = new StreamReader(Retpath);
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
        string Kospath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostiosad.txt");
        List<string> koostisosad = new List<string>();
        while (true)
        {
            Console.Write("Sisesta Koostisosa/kui kõik sisesta kõik: ");
            string sisend = Console.ReadLine();

            if (sisend == "kõik")
                break;

            koostisosad.Add(sisend);

        }
        if (koostisosad.Count > 0)
        {
            koostisosad[0] = "Kvaliteetne oliiviõli";
        }


        koostisosad.Remove("Ketšup");


        Console.WriteLine("\nUuenenud nimekiri:");
        foreach (string koostisosa in koostisosad)
        {
            Console.WriteLine("- " + koostisosa);



        }
        return koostisosad;

    }
    

}
        

    

