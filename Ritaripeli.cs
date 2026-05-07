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
                // TODO anna pelaajan valita toiminto:
                // 1. hyökkää : aiheuta vahinkoa hirviölle
                // 2. käytä esinettä ; näytä Repun sisältö ja anna pelaajan valita tavara
                // Jos pelaaja käyttää ruoka-annosta, lisää pelaajan osumapisteitä
                // Jos pelaaja käyttää nuolta, ammu nuoli kohti vihollista
                // Jos pelaaja käyttää jotain muuta tavaraa, toimi valinnan mukaan
                // 3. pakene : poistu TaisteluTilasta

                // TODO Jos hirviöllä on osumapisteitä jäljellä
                // arvo hirviön tekemä vahinko ja vähennä se pelaajan osumapisteistä
            }
            // Kun taistelu loppuu, palaa PeliSilmukkaan
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
            // TODO listaa nuolikaupan nuolivaihtoehdot ja anna pelaajan valita minkä hän haluaa ostaa
            // tarkista onko pelaajalla tarpeeksi rahaa ja jos on, vähennä hinta pelaajan rahapussista ja lisää nuoli pelaajan reppuun
        }
    }
}
