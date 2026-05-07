using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class NuoliaKaupan
    {
        enum kärki
        {
            puu, // 3
            teräs, // 5 
            timantti // 50
        }
        enum perä
        {
            lehti, // 0
            kanansulka, // 1
            kotkansulka // 5
        }
        class Nuoli
        {
            public kärki Kärki { get; }
            public perä Perä { get; }
            public int Pituus { get; }
            public Nuoli(kärki kärki, perä perä, int pituus)
            {
                this.Kärki = kärki;
                this.Perä = perä;
                this.Pituus = pituus;
            }
            public int LaskeHinta()
            {
                double hinta = 0;
                switch (Kärki)
                {
                    case kärki.puu:
                        hinta += 3;
                        break;
                    case kärki.teräs:
                        hinta += 5;
                        break;
                    case kärki.timantti:
                        hinta += 50;
                        break;
                }
                switch (Perä)
                {
                    case perä.lehti:
                        hinta += 0;
                        break;
                    case perä.kanansulka:
                        hinta += 1;
                        break;
                    case perä.kotkansulka:
                        hinta += 5;
                        break;
                }
                hinta += Pituus * 0.05;

                return (int)hinta;
            }
            public static Nuoli LuoEliittiNuoli()
            {
                return new Nuoli(kärki.timantti, perä.kotkansulka, 100);
            }

            public static Nuoli LuoAloittelijaNuoli()
            {
                return new Nuoli(kärki.puu, perä.kanansulka, 70);
            }

            public static Nuoli LuoPerusNuoli()
            {
                return new Nuoli(kärki.teräs, perä.kanansulka, 85);
            }
        }
        public void NuoliKauppa() 
        {
            Console.WriteLine("Tervetuloa nuolikauppaan!");
            Console.WriteLine("Haluatko:");
            Console.WriteLine("1. Teettää custom nuolen");
            Console.WriteLine("2. Ostaa valmiin nuolen");

            string nuoliValinta = Console.ReadLine();
            Nuoli nuoli = null;

            if (nuoliValinta == "1")
            {
                Console.WriteLine("Valitse nuolen kärki: puu, teräs, timantti");
                string kärkiValinta = Console.ReadLine();
                kärki valittuKärki = KärkiString(kärkiValinta);

                Console.WriteLine("Valitse nuolen perä: lehti, kanansulka, kotkansulka");
                string peräValinta = Console.ReadLine();
                perä valittuPerä = PeräString(peräValinta);

                Console.WriteLine("Valitse pituus (60-100):");
                int pituus = int.Parse(Console.ReadLine());

                nuoli = new Nuoli(valittuKärki, valittuPerä, pituus);
            }
            else if (nuoliValinta == "2")
            {
                Console.WriteLine("Minkäs näistä tahtoisit ostaa:");
                Console.WriteLine("1. Eliittinuoli: Kärki timantti, perä kotkansulka, pituus 100");
                Console.WriteLine("2. Aloittelijanuoli: Kärki puu, perä kanansulka, pituus 70");
                Console.WriteLine("3. Perusnuoli: Kärki teräs, perä kanansulka, pituus 85");
                string valmisNuoliValinta = Console.ReadLine();

                nuoli = valmisNuoliValinta switch
                {
                    "1" => Nuoli.LuoEliittiNuoli(),
                    "2" => Nuoli.LuoAloittelijaNuoli(),
                    "3" => Nuoli.LuoPerusNuoli(),
                    _ => null
                };
            }
            if (nuoli != null)
            {
                int hinta = nuoli.LaskeHinta();
                LopullinenHinta(hinta);
            }
            else
            {
                Console.WriteLine("Virheellinen valinta.");
            }
        }

        static kärki KärkiString(string kärkiValinta)
        {
            return kärkiValinta switch
            {
                "puu" => kärki.puu,
                "teräs" => kärki.teräs,
                "timantti" => kärki.timantti,
                _ => kärki.puu
            };
        }

        static perä PeräString(string peräValinta)
        {
            return peräValinta switch
            {
                "lehti" => perä.lehti,
                "kanansulka" => perä.kanansulka,
                "kotkansulka" => perä.kotkansulka,
                _ => perä.lehti
            };
        }

        static void LopullinenHinta(int hinta)
        {
            Console.WriteLine($"Nuolen hinta on: {hinta} kolikkoa");
        }
    }
}
