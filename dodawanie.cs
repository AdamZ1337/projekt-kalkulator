using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class dodawanie : dzialanie
    {
        public dodawanie(double _a, double _b) : base(_a, _b)
        {
        }

        public override string DzialanieMatematyczne()
        {
            return (this.a + this.b).ToString();
          
        }
    }
}
