﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ysa_Example
{
    class MinToplamFonkHesaplama : IToplamaFonk
    {
        public double Toplamahesapla(int parametre, float[] dizi, double[] agirlikdizi)
        {
            double[] dizi2 = new double[parametre];
            for (int i = 0; i < parametre; i++)
            {
                dizi2[i] = dizi[i] * agirlikdizi[i];
            }

            double min = dizi2[0];
            for (int i = 1; i < parametre; i++)
            {
                if (min > dizi2[i])
                    min = dizi2[i];
            }

            return min;
        }
    }
}
