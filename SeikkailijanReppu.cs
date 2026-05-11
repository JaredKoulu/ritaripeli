namespace ritaripeli
{
    internal partial class SeikkailijanReppu
    {
        public void NäytäReppu()
        {
            Reppu reppu = new(10, 30, 20);
            Console.WriteLine($"Repussasi on tällähetkellä: {reppu.TavaraMaara}/{reppu.maxMaara} tavaraa, {reppu.NykyPaino}/{reppu.maxPaino} painoa ja {reppu.NykyTilavuus}/{reppu.maxTilavuus} tilavuus.");
            Console.WriteLine("Repun sisältö: " + reppu);
            /*
            Console.WriteLine("Mitä haluat lisätä?");
            Console.WriteLine("1. Nuoli (painaa 0.1 ja tilavuus 0.05)");
            Console.WriteLine("2. Jousi (painaa 1 ja tilavuus 4)");
            Console.WriteLine("3. Köysi (painaa 1 ja tilavuus 1.5)");
            Console.WriteLine("4. Vesi (painaa 2 ja tilavuus 2)");
            Console.WriteLine("5. Ruoka (painaa 1 ja tilavuus 0.5)");
            Console.WriteLine("6. Miekka (painaa 5 ja tilavuus 3)");
            string lisäysValinta = Console.ReadLine();
            if (lisäysValinta == "1")
            {
                Nuoli nuoli = new Nuoli();
                if (reppu.Lisää(nuoli))
                {
                    Console.WriteLine("Nuoli lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Nuolia ei voitu lisätä reppuun.");
                }
            }
            if (lisäysValinta == "2")
            {
                Jousi jousi = new Jousi();
                if (reppu.Lisää(jousi))
                {
                    Console.WriteLine("Jousi lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Jousia ei voitu lisätä reppuun.");
                }
            }
            if (lisäysValinta == "3")
            {
                Köysi köysi = new Köysi();
                if (reppu.Lisää(köysi))
                {
                    Console.WriteLine("Köysi lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Köysiä ei voitu lisätä reppuun.");
                }
            }
            if (lisäysValinta == "4")
            {
                Vesi vesi = new Vesi();
                if (reppu.Lisää(vesi))
                {
                    Console.WriteLine("Vesi lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Vettä ei voitu lisätä reppuun.");
                }
            }
            if (lisäysValinta == "5")
            {
                Ruoka ruoka = new Ruoka();
                if (reppu.Lisää(ruoka))
                {
                    Console.WriteLine("Ruoka lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Ruokaa ei voitu lisätä reppuun.");
                }
            }
            if (lisäysValinta == "6")
            {
                Miekka miekka = new Miekka();
                if (reppu.Lisää(miekka))
                {
                    Console.WriteLine("Miekka lisätty reppuun.");
                }
                else
                {
                    Console.WriteLine("Miekkaa ei voitu lisätä reppuun.");
                }
            }*/
        }
    }
}
