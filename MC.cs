using System;
using System.Collections.Generic;
using System.Text;

namespace billetlibrary_Rovsneglen
{
    class MC: Køretøj
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }

        public bool Brobizz { get; set; }

        public MC()
        {
            
        }

        public override double Pris(bool Brobizz)
        {
            if (Brobizz)
                return 125 * 0.95;
            return 125;
        }

        public override string køretøj()
        {
            return "MC";
        }


        public override bool CheckBrobizz()
        {
            return Brobizz;
        }
    }
}
