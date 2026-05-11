using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
    /// <summary>
    /// Tämä on pohjaluokka kaikille pelin hirviöille
    /// </summary>
    internal abstract class Hirviö
	{
		public int Osumapisteet { get; set; }
		public string Nimi { get; set; }
		public abstract int AnnaVahinko();
		public abstract void OtaVahinkoa(int määrä);
		public Ritari pelaaja { get; set; }
    }

	internal class Örkki : Hirviö
	{
		public Örkki()
		{
			Nimi = "Örkki";
			Osumapisteet = 3;
		}

		public override int AnnaVahinko()
		{
			return 2;
		}

		public override void OtaVahinkoa(int määrä)
		{
			Osumapisteet -= määrä;
			if (Osumapisteet < 0)
			{ 
				Osumapisteet = 0;
				pelaaja.Rahapussi.LisääRahaa(5);
            }

		}
	}

	internal class Lohikäärme : Hirviö
	{
		public Lohikäärme()
		{
			Nimi = "Lohikäärme";
			Osumapisteet = 10;
		}

		public override int AnnaVahinko()
		{
			return 4;
		}

		public override void OtaVahinkoa(int määrä)
		{
			Osumapisteet -= määrä;
			if (Osumapisteet < 0)
			{
				Osumapisteet = 0;
				pelaaja.Rahapussi.LisääRahaa(20);
            }
		}
	}

	internal class Mörkö : Hirviö
	{
		public Mörkö()
		{
			Nimi = "Mörkö";
			Osumapisteet = 5;
		}

		public override int AnnaVahinko()
		{
			return 3;
		}

		public override void OtaVahinkoa(int määrä)
		{
			Osumapisteet -= määrä;
			if (Osumapisteet < 0)
			{
				Osumapisteet = 0;
				pelaaja.Rahapussi.LisääRahaa(7);
			}
		}
	}
}
