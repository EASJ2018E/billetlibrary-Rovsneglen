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

        public override double Pris(bool Brobizz)
        {
            if (Brobizz)
                return 240 * 0.95;
            return 240;
        }

        public override string køretøj()
        {
            return "Bil";
        }

        public override bool CheckBrobizz()
        {
            return Brobizz;
        }
    }
}
