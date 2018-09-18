using System;
using System.Collections.Generic;
using System.Text;

namespace billetlibrary_Rovsneglen
{
    public abstract class Køretøj
    {
        string Nummerplade { get; set; }
        DateTime Dato { get; set; }
        bool Brobizz { get; set; }

        public virtual double Pris(bool Brobizz)
        {

            return 0;
        }

        public virtual string køretøj()
        {
            return "Denne metode er ikke overloaded";
        }

        public void ForkertNummerplade()
        {
            if (Nummerplade.Length != 7)
            {
                throw new Exception("Forkert Nummerplade");
            }
        }

        public virtual bool CheckBrobizz()
        {
            return false;
        }
    }
}
