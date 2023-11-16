using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi2
{
    internal class Hesap
    {
        public Double Topla(Double x, Double y)
        {
            return x + y;
        }
        public Double Cikar(Double x, Double y)
        {
            return x - y;
        }
        public Double Carp(Double x, Double y)
        {
            return x * y;
        }
        public Double Bol(Double x, Double y)
        {
            Double sonuc;
            if (y != 0)
            {
                sonuc= x / y;
            }
            else
            {
                sonuc = 0;
            }
            return sonuc;
        }
        public Double Karekok(Double x)
        { 
            return Math.Sqrt(x); 
        }
        public Double UsAl(Double taban,Double us)
        {
            return Math.Pow(taban, us);
        }
    }
}
