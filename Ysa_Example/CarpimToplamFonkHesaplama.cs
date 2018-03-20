using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ysa_Example
{
    class CarpimToplamFonkHesaplama : IToplamaFonk
    {
        public double Toplamahesapla(int parametre, float[] dizi, double[] agirlikdizi)
        {
            double toplam = 0;

            for (int i=0;i<parametre;i++)
            {
                toplam *= dizi[i] * agirlikdizi[i];
            }

            return toplam;
        }
    }
}
