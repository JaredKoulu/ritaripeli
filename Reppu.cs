namespace ritaripeli
{

    public class Reppu
    {
        List<Tavara> tavarat;

        public int maxMaara;
        public double maxPaino;
        public double maxTilavuus;

        public Reppu(int maxMaara, double maxPaino, double maxTilavuus)
        {
            this.maxMaara = maxMaara;
            this.maxPaino = maxPaino;
            this.maxTilavuus = maxTilavuus;

            tavarat = new List<Tavara>();

        }
        public int TavaraMaara
        {
            get { return tavarat.Count; }
        }
        public double NykyPaino
        {
            get
            {
                double summa = 0;
                foreach (Tavara t in tavarat)
                {
                    summa += t.Paino;
                }
                return summa;
            }
        }
        public double NykyTilavuus
        {
            get
            {
                double summa = 0;
                foreach (Tavara t in tavarat)
                {
                    summa += t.Tilavuus;
                }
                return summa;
            }
        }
        public bool Lisää(Tavara tavara)
        {
            if (TavaraMaara + 1 > maxMaara)
                return false;
            if (NykyPaino + tavara.Paino > maxPaino)
                return false;
            if (NykyTilavuus + tavara.Tilavuus > maxTilavuus)
                return false;

            tavarat.Add(tavara);
            return true;
        }
        public override string ToString()
        {
            return string.Join(", ", tavarat);
        }
    }
}
