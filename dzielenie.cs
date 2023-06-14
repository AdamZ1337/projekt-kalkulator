using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class dzielenie : dzialanie
    {
        public dzielenie(double _a, double _b) : base(_a, _b)
        {
        }

        public override string DzialanieMatematyczne()
        {
            if (this.b == 0) 
            {
                return "nie mozna dzielic przez zero";
            }
            return (this.a / this.b).ToString();

        }
    }
}
