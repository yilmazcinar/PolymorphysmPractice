using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphysmOOP
{
    internal class BaseGeometri
    {
        public double Genislik {  get; set; }

        public double Yukseklik { get; set; }

        public BaseGeometri(double x, double y)
        {
            Genislik = x;
            Yukseklik = y;

        }

        public virtual double AlanHesapla(double x, double y)
        {

            return x * y;

        }

        
    }
}
