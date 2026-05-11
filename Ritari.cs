using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritaripeli
{
	internal class Ritari
	{
		public int Osumapisteet {  get; private set; }
		public Lompakko Rahapussi { get; private set; }
        public Reppu Reppu { get; private set; }
		public Ritari(int aloitusOsumapisteet, int aloitusRahat, int maxMaara, double maxPaino, double maxTilavuus)
        {
			Osumapisteet = aloitusOsumapisteet;
			Rahapussi = new Lompakko(aloitusRahat);
			Reppu = new Reppu(maxMaara, maxPaino, maxTilavuus);

        }

		public void OtaVahinkoa(int määrä)
		{
            if (Osumapisteet >= määrä)
            {
                Osumapisteet -= määrä;
            }
            else
            {
                Osumapisteet = 0;
            }
        }
    }
}
