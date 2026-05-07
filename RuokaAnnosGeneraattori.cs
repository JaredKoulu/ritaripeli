using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    internal class RuokaAnnosGeneraattori
    {
        enum PääRaakaAine
        {
            Nauta,
            Kana,
            Kasvis
        }

        enum Lisuke
        {
            Peruna,
            Riisi,
            Pasta
        }

        enum Kastike
        {
            Curry,
            Tomaatti,
            Pippuri,
            Chili
        }
        class Ateria
        {
            private PääRaakaAine PääRaakaAine;
            private Lisuke Lisuke;
            private Kastike Kastike;

            public Ateria(PääRaakaAine pääRaakaAine, Lisuke lisuke, Kastike kastike)
            {
                this.PääRaakaAine = pääRaakaAine;
                this.Lisuke = lisuke;
                this.Kastike = kastike;
            }
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse pääruoka. Nauta, Kana tai Kasvis.");
            string pääRaakaAine = Console.ReadLine();
            Console.WriteLine("Valitse lisuke. Peruna, Riisi tai Pasta.");
            string lisuke = Console.ReadLine();
            Console.WriteLine("Valitse kastike. Curry, Tomaatti, Pippuri tai Chili.");
            string kastike = Console.ReadLine();
            Console.WriteLine($"Generoitava ateria on: {pääRaakaAine}, {lisuke} ja {kastike}");
        }
        */
    }
}
