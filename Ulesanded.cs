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
    public static void KulmkapiKontroll()
    {
        string Kospath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
        List<string> koostisosad = new List<string>();

        if (File.Exists(Kospath))
        {
            koostisosad = new List<string>(File.ReadAllLines(Kospath));
        }
        else
        {
            koostisosad = new List<string> { "jahu", "munad", "piim", "või", "sool", "suhkur", "küpsetuspulber" };
        }

        Console.WriteLine("\nRetsepti koostisosad:");
        foreach (string k in koostisosad)
            Console.WriteLine("- " + k);

        Console.Write("\nSisesta koostisosa, mida soovid otsida: ");
        string otsitav = Console.ReadLine();

        if (koostisosad.Contains(otsitav))
            Console.WriteLine("Koostisosa on olemas!");
        else
            Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
    }



    public static void SalvestaUuendatudNimekiri()
    {
        string Kospath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
        List<string> koostisosad = new List<string>();

        if (File.Exists(Kospath))
        {
            koostisosad = new List<string>(File.ReadAllLines(Kospath));
        }
        else
        {
            koostisosad = new List<string> { "jahu", "munad", "piim", "või", "sool", "ketšup", "suhkur" };
        }

        Console.WriteLine("\nAlgne nimekiri:");
        foreach (string k in koostisosad)
            Console.WriteLine("- " + k);

        koostisosad.Add("oliiviõli");
        koostisosad.Remove("ketšup");

        Console.WriteLine("\nUuendatud nimekiri (oliiviõli lisatud, ketšup eemaldatud):");
        foreach (string k in koostisosad)
            Console.WriteLine("- " + k);

        File.WriteAllLines(Kospath, koostisosad);
        Console.WriteLine("\nUus retsept on edukalt faili salvestatud!");
    }















    public static void ItaaliaRestoran()
    {
        string[] read = {
            "Margherita pitsa;San Marzano tomatid, värske mozzarella, basiilik;8.50",
            "Pasta Carbonara;Spagetid, guanciale, pecorino juust, muna;12.00",
            "Tiramisu;Mascarpone, espresso, savoiardi küpsised;6.50"
        };
        File.WriteAllLines("Menuu.txt", read);

        List<Tuple<string, string, double>> menyyList = new List<Tuple<string, string, double>>();

        string[] read2 = File.ReadAllLines("Menuu.txt");

        foreach (string rida in read2)
        {
            string[] osad = rida.Split(';');
            menyyList.Add(Tuple.Create(osad[0], osad[1], double.Parse(osad[2], System.Globalization.CultureInfo.InvariantCulture)));
        }

        Console.WriteLine("╔══════════════════════════════════════════════════╗");
        Console.WriteLine("║           ITAALIA RESTORAN                      ║");
        Console.WriteLine("╚══════════════════════════════════════════════════╝");

        foreach (var roog in menyyList)
        {
            Console.WriteLine($"\n  {roog.Item1.PadRight(35)} {roog.Item3:F2} €");
            Console.WriteLine($"    {roog.Item2}");
            Console.WriteLine("  " + new string('-', 48));
        }

        Console.WriteLine("-----do-------");
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        do
        {
            Console.WriteLine("Vajuta Backspace");
            key = Console.ReadKey();
        }
        while (key.Key != ConsoleKey.Backspace);
    }



}

        

    

