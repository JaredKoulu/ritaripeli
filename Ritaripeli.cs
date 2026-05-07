namespace ritaripeli
{
    internal class Ritaripeli
    {
        Ritari pelaaja;

        List<Hirviö> hirviot;
        List<IKauppa> kaupat;
        public Ritaripeli()
        {
            pelaaja = new Ritari(aloitusOsumapisteet: 10, aloitusRahat: 10);
            hirviot = new List<Hirviö>();
            // TODO luo erilaiset hirviöt
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
                }

                // Tarkista onko peli päättynyt
            }
        }


        public void TaisteluTila()
        {
            // TODO arvo pelaajaa vastaan taisteleva hirviö
            Hirviö vastustaja = null;
            while (vastustaja.Osumapisteet > 0 && pelaaja.Osumapisteet > 0)
            {
                Print.LineColor("Valitse toiminto: ", ConsoleColor.White);
                Print.LineColor("1. Hyökkää viholliseen", ConsoleColor.White);
                Print.LineColor("2. Käytä esinettä Repusta", ConsoleColor.White);
                Print.LineColor("3. Pakene taistelusta", ConsoleColor.White);

                // TODO anna pelaajan valita toiminto:
                string valinta = Console.ReadLine();
                if (valinta == "1")
                {
                    // 1. hyökkää : aiheuta vahinkoa hirviölle
                    int pelaajanVahinko = 1;
                    vastustaja.OtaVahinkoa(pelaajanVahinko);
                    Print.LineColor($"Hyökkäsit {vastustaja.Nimi} ja aiheutit {pelaajanVahinko} vahinkoa!", ConsoleColor.Green);
                }
                else if (valinta == "2")
                {
                // 2. käytä esinettä ; näytä Repun sisältö ja anna pelaajan valita tavara
                // Jos pelaaja käyttää ruoka-annosta, lisää pelaajan osumapisteitä
                // Jos pelaaja käyttää nuolta, ammu nuoli kohti vihollista
                // Jos pelaaja käyttää jotain muuta tavaraa, toimi valinnan mukaan
                }
                else if (valinta == "3")
                {
                // 3. pakene : poistu TaisteluTilasta
                    Print.LineColor("Pakenit taistelusta!", ConsoleColor.Yellow);
                    return;
                }


                // TODO Jos hirviöllä on osumapisteitä jäljellä

                // arvo hirviön tekemä vahinko ja vähennä se pelaajan osumapisteistä
            }
            // Kun taistelu loppuu, palaa PeliSilmukkaan
            if (pelaaja.Osumapisteet <= 0)
            {
                Print.LineColor("Hävisit taistelun! Peli päättyy.", ConsoleColor.Red);
                Environment.Exit(0);
            }
            else if (vastustaja.Osumapisteet <= 0)
            {
                Print.LineColor("Voitit taistelun!", ConsoleColor.Green);
                // TODO palkitse pelaaja voitosta, esimerkiksi lisää rahaa tai anna esineitä
            }
        }

        public void KauppaTila()
        {
            // TODO anna pelaajan valita mihin kauppaan pelaaja menee
            // listaa kaupan tavarat ja anna pelaajan valita minkä hän haluaa
            // yrittää ostaa
            // lisää vaihtoehto jolla pelaaja pääsee pois kaupasta ja Kauppatilasta
        }
        public void NuoliKauppaTila()
        {
            NuoliaKaupan nuoliKauppa = new NuoliaKaupan();
            nuoliKauppa.NuoliKauppa();
            // TODO listaa nuolikaupan nuolivaihtoehdot ja anna pelaajan valita minkä hän haluaa ostaa
            // tarkista onko pelaajalla tarpeeksi rahaa ja jos on, vähennä hinta pelaajan rahapussista ja lisää nuoli pelaajan reppuun
        }
    }
}
