using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphysmOOP
{
    internal class Ucgen : BaseGeometri
    {
        public Ucgen(double x, double y) : base(x, y)
        {

        }
        public override double AlanHesapla(double x, double y)
        {
            return x * y / 2 ;
        }
    }
}
