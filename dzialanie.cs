using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    abstract class dzialanie
    {
       public double a;
        public double b;
        public string wynik="brak dzialania";
        public virtual string DzialanieMatematyczne ()
        {
            return wynik;
        }
        public dzialanie(double _a, double _b)
        {
            this.a = _a;
            this.b = _b;

        }
    }
}
