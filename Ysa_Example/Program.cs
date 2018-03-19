using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ysa_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            int parametre;
            int altsinir, ustsinir;

            Console.WriteLine("Parametre Sayısını Giriniz");
            parametre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Al sınır Giriniz");
            altsinir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üst Sınır  Giriniz");
            ustsinir = Convert.ToInt32(Console.ReadLine());

            float[] dizi = new float[parametre];

            Random rastgele = new Random();
            for (int i=0;i<parametre;i++)
            {
                
                int sayi = rastgele.Next(altsinir,ustsinir);
                dizi[i] = sayi;
                Console.WriteLine(dizi[i]);
            }

            double[] agirlik = new double[parametre];
            Random agirlikr = new Random();
            for (int i = 0; i < parametre; i++)
            {

                double sayi2 = agirlikr.NextDouble();
                agirlik[i] = sayi2;
                Console.WriteLine(agirlik[i]);
            }

            Console.WriteLine("Toplama Fonksiyonu Seçiniz");
            ToplamToplamFonkHesapla tp = new ToplamToplamFonkHesapla();
            double sonuc=tp.Toplamahesapla(parametre,dizi,agirlik);

            SigmoidAktivasyon sm = new SigmoidAktivasyon();
            Console.WriteLine(sm.Aktivasyonhesapla(sonuc));



            Console.ReadKey();

        }
    }
}
