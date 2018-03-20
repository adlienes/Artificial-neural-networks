using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ysa_Example
{
    class HiperbolikAktivasyon : IAktivasyon
    {
        public double Aktivasyonhesapla(double sonuc)
        {
            double hucrecikis = 0;
            double e = Math.E;
            double sonuc1 = -2 * sonuc;
            double sonuc2 = 2 * sonuc;
            double üs1 = Math.Pow(e, sonuc1);
            double üs2 = Math.Pow(e, sonuc2);
            hucrecikis = (1 - üs1) / (1 + üs2);
            return hucrecikis;
        }
    }
}
