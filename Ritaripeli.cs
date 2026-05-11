namespace ritaripeli
{
    internal class Ritaripeli
    {
        Ritari pelaaja;

        List<Hirviö> hirviot;
        List<IKauppa> kaupat;
        Reppu reppu = new(10, 30, 20);
        public Ritaripeli()
        {
            pelaaja = new Ritari(aloitusOsumapisteet: 10, aloitusRahat: 10, maxMaara: 10, maxPaino: 30, maxTilavuus: 20);
            hirviot = new List<Hirviö>();
            // TODO luo erilaiset hirviöt
            hirviot = new List<Hirviö>
            {
                new Örkki(),
                new Lohikäärme(),
                new Mörkö()
            };
            kaupat = new List<IKauppa>();
            // TODO luo erilaiset kaupat
        }

        public void PeliSilmukka()
        {
            Print.Line("Tervetuloa suureen seikkailuun!");
            while (true)
            {

                // TODO näytä pelaajan tilanne
                Print.WriteColor("Tilanne: Osumapisteitä: ", ConsoleColor.White);
                Print.WriteColor($"{pelaaja.Osumapisteet} op ", ConsoleColor.Green);
                Print.WriteColor("Kultaa: ", ConsoleColor.White);
                Print.LineColor($"{pelaaja.Rahapussi.Rahoja} kr", ConsoleColor.Yellow);
                // TODO anna pelaajan valita meneekö kauppaan vai taistelemaan vai käyttääkö tavaroita Repusta
                Print.LineColor("Valitse toiminto: ", ConsoleColor.White);
                Print.LineColor("1. Mene nuolikauppaan", ConsoleColor.White);
                Print.LineColor("2. Mene ruokakauppaan", ConsoleColor.White);
                Print.LineColor("3. Mene taistelemaan", ConsoleColor.White);
                Print.LineColor("4. Käytä tavaroita Repusta", ConsoleColor.White);
                string valinta = Console.ReadLine();
                if (valinta == "1")
                {
                    // TODO mene nuolikauppaan
                    NuoliKauppaTila();
                }
                if (valinta == "2")
                {
                    // TODO mene ruokakauppaan
                    KauppaTila();
                }
                if (valinta == "3")
                {
                    // TODO mene taistelemaan
                    TaisteluTila();
                }
                if (valinta == "4")
                {
                    // TODO näytä Repun sisältö ja anna pelaajan valita tavara
                    ReppuTila();
                }

                // Tarkista onko peli päättynyt
            }
        }


        public void TaisteluTila()
        {
            Random random = new Random();
            Hirviö? vastustaja = hirviot[random.Next(hirviot.Count)];
            Ritari? pelaaja = this.pelaaja;
            
            Print.LineColor($"Kohtasit {vastustaja.Nimi}:n!", ConsoleColor.Yellow);

            while (vastustaja?.Osumapisteet > 0 && pelaaja?.Osumapisteet > 0)
            {
                Print.LineColor("Valitse toiminto: ", ConsoleColor.White);
                Print.LineColor("1. Hyökkää viholliseen", ConsoleColor.White);
                Print.LineColor("2. Käytä esinettä Repusta", ConsoleColor.White);
                Print.LineColor("3. Pakene taistelusta", ConsoleColor.White);

                // TODO anna pelaajan valita toiminto:
                string? valinta = Console.ReadLine();
                if (valinta == "1")
                {
                    // 1. hyökkää : aiheuta vahinkoa hirviölle
                    int pelaajanVahinko = 1;
                    vastustaja?.OtaVahinkoa(pelaajanVahinko);
                    Print.LineColor($"Hyökkäsit {vastustaja?.Nimi} ja aiheutit {pelaajanVahinko} vahinkoa!", ConsoleColor.Green);
                }
                else if (valinta == "2")
                {
                    ReppuTila();
                }
                else if (valinta == "3")
                {
                    // 3. pakene : poistu TaisteluTilasta
                    Print.LineColor("Pakenit taistelusta!", ConsoleColor.Yellow);
                    return;
                }

                // TODO Jos hirviöllä on osumapisteitä jäljellä

                // arvo hirviön tekemä vahinko ja vähennä se pelaajan osumapisteistä
                if (vastustaja?.Osumapisteet > 0)
                {
                    int hirviönVahinko = vastustaja.AnnaVahinko();
                    pelaaja?.OtaVahinkoa(hirviönVahinko);
                    Print.LineColor($"{vastustaja?.Nimi} hyökkäsi sinua ja aiheutti {hirviönVahinko} vahinkoa!", ConsoleColor.Red);
                }
            }
            
            // Kun taistelu loppuu, palaa PeliSilmukkaan
            if (pelaaja?.Osumapisteet <= 0)
            {
                Print.LineColor("Hävisit taistelun! Peli päättyy.", ConsoleColor.Red);
                Environment.Exit(0);
            }
            else if (vastustaja?.Osumapisteet <= 0)
            {
                Print.LineColor("Voitit taistelun!", ConsoleColor.Green);
                // TODO palkitse pelaaja voitosta, esimerkiksi lisää rahaa tai anna esineitä
            }
        }

        public void KauppaTila()
        {

            Print.LineColor("Tervetuloa ruokakauppaan!", ConsoleColor.White);
            Print.LineColor("Haluatko ostaa 1. ruokaa vai 2. lähteä? ", ConsoleColor.White);
            string valinta = Console.ReadLine();
            if (valinta == "1")
            {
                Print.LineColor("Valitse ruokavaihtoehto: ", ConsoleColor.White);
                // TODO listaa kaupan ruokavaihtoehdot ja anna pelaajan valita minkä hän haluaa ostaa
                Print.LineColor("Valitse ruokavaihtoehto: ", ConsoleColor.White);
                Print.LineColor("1. Leipä (5 kr)", ConsoleColor.White);
                Print.LineColor("2. Juusto (7 kr)", ConsoleColor.White);
                Print.LineColor("3. Liha (10 kr)", ConsoleColor.White);
                Print.LineColor("4. Lähde kaupasta", ConsoleColor.White);
                string Ruokavalinta = Console.ReadLine();
                if (Ruokavalinta == "1")
                {
                    if (pelaaja.Rahapussi.Rahoja >= 5)
                    {
                        pelaaja.Rahapussi.OtaRahaa(5);
                        Leipä leipä = new Leipä();
                        if (reppu.Lisää(leipä))
                        {

                        Print.LineColor("Ostit leipää ja lisäsit sen reppuusi!", ConsoleColor.Green);
                        }
                        else
                        {
                            Print.LineColor("Ruokaa ei voitu lisätä reppuun tilanvuoksi.", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Print.LineColor("Sinulla ei ole tarpeeksi rahaa ostaaksesi leipää!", ConsoleColor.Red);
                    }
                }
                if (Ruokavalinta == "2")
                {
                    if (pelaaja.Rahapussi.Rahoja >= 7)
                    {
                        pelaaja.Rahapussi.OtaRahaa(7);
                        Juusto juusto = new Juusto();
                        if (reppu.Lisää(juusto))
                        {
                            Print.LineColor("Ostit juustoa ja lisäsit sen reppuusi!", ConsoleColor.Green);
                        }
                        else
                        {
                            Print.LineColor("Ruokaa ei voitu lisätä reppuun tilanvuoksi.", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Print.LineColor("Sinulla ei ole tarpeeksi rahaa ostaaksesi juustoa!", ConsoleColor.Red);
                    }
                }
                if (Ruokavalinta == "3")
                {
                    if (pelaaja.Rahapussi.Rahoja >= 10)
                    {
                        pelaaja.Rahapussi.OtaRahaa(10);
                        Liha liha = new Liha();
                        if (reppu.Lisää(liha))
                        {
                        Print.LineColor("Ostit lihaa ja lisäsit sen reppuusi!", ConsoleColor.Green);
  
                        }
                        else
                        {
                            Print.LineColor("Ruokaa ei voitu lisätä reppuun tilanvuoksi.", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Print.LineColor("Sinulla ei ole tarpeeksi rahaa ostaaksesi lihaa!", ConsoleColor.Red);
                    }
                }
                if (Ruokavalinta == "4")
                {
                    Print.LineColor("Lähdit kaupasta!", ConsoleColor.Yellow);
                    return;
                }
            }
            if (valinta == "2")
            {
                Print.LineColor("Lähdit kaupasta!", ConsoleColor.Yellow);
                return;
            }
        }
        public void NuoliKauppaTila()
        {
            NuoliaKaupan nuoliKauppa = new NuoliaKaupan();
            nuoliKauppa.NuoliKauppa();
            // TODO listaa nuolikaupan nuolivaihtoehdot ja anna pelaajan valita minkä hän haluaa ostaa
            // tarkista onko pelaajalla tarpeeksi rahaa ja jos on, vähennä hinta pelaajan rahapussista ja lisää nuoli pelaajan reppuun
        }
        public void ReppuTila()
        {
            // TODO näytä Repun sisältö ja anna pelaajan valita tavara
            Print.LineColor($"Repussasi on tällähetkellä: {reppu.TavaraMaara}/{reppu.maxMaara} tavaraa, {reppu.NykyPaino}/{reppu.maxPaino} painoa ja {reppu.NykyTilavuus}/{reppu.maxTilavuus} tilavuus.", ConsoleColor.White);
            Print.LineColor("Repun sisältö: " + reppu, ConsoleColor.Yellow);
            Print.LineColor("Valitse tavara, jonka haluat käyttää vai haluatko lähteä?: ", ConsoleColor.White);
            if (reppu.TavaraMaara > 0)
            {
                string valinta = Console.ReadLine();
                // TODO tarkista valinta ja toimi sen mukaan
                if (valinta == "leipä" || valinta == "juusto" || valinta == "liha")
                {
                    // jos pelaaja valitsee ruokaa, lisää pelaajan osumapisteitä
                    int osumapisteidenLisays = 0;
                    if (valinta == "leipä")
                    {
                        osumapisteidenLisays = 5;
                    }
                    else if (valinta == "juusto")
                    {
                        osumapisteidenLisays = 7;
                    }
                    else if (valinta == "liha")
                    {
                        osumapisteidenLisays = 10;
                    }
                }
                // jos pelaaja valitsee nuolen, ammu nuoli kohti vihollista
            if (valinta == "nuoli")
                {
                    // TODO ammu nuoli kohti vihollista, aiheuta vahinkoa viholliselle ja poista nuoli reppusta
                }
                // jos pelaaja valitsee jotain muuta tavaraa, toimi valinnan mukaan

            if (valinta == "lähde")
                {
                    return;
                }
            }
        }
    }
}
