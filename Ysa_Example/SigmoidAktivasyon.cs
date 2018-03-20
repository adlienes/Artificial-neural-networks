﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ysa_Example
{
    class SigmoidAktivasyon : IAktivasyon
    {
        public double Aktivasyonhesapla(double sonuc)
        {
            double hucrecikis = 0;
            double e = Math.E;
            double üs = Math.Pow(e, sonuc);
            hucrecikis = 1 / (1 + üs);
            return hucrecikis;
        }
    }
}
