using System;

namespace billetlibrary_Rovsneglen
{
    public class Bil: Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }

        public Bil()
        {
            
        }

        /// <summary>
        /// Metoden "Pris" bestemmer prisen for en motorcykel. Hvis der er BroBizz,
        /// så bliver der givet 5% rabat, ellers betales der fuld pris (125 kr.)
        /// </summary>
        /// <param name="Brobizz"></param>
        /// <returns></returns>
        public override double Pris(bool Brobizz)
        {
            if (Brobizz)
                return 240 * 0.95;
            return 240;
        }

        /// <summary>
        /// Metoden "Køretøj" bestemmer typen af køretøj. Typen bliver retuneret
        /// som en streng.
        /// </summary>
        /// <returns></returns>
        public override string køretøj()
        {
            return "Bil";
        }

        /// <summary>
        /// Metoden "CheckBroBizz" tjekker om der er en BroBizz. Hvis
        /// den er "true", så retunerer den BroBizz.
        /// </summary>
        /// <returns></returns>
        public override bool CheckBrobizz()
        {
            return Brobizz;
        }
    }
}
