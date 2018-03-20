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

            Console.WriteLine();
            Console.WriteLine();

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

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplama Fonksiyonu Seçiniz --------------->");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplam Toplama Fonksiyonu için 1'i Seçiniz");
            Console.WriteLine("Çarpım Toplama Fonksiyonu için 2'i Seçiniz");
            Console.WriteLine("Max Toplama Fonksiyonu için 3'i Seçiniz");
            Console.WriteLine("Min Toplama Fonksiyonu için 4'i Seçiniz");

            double sonuc = 0;

            int caseSwitch=Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Toplam Toplama Fonksiyonu Seçildi");
                    ToplamToplamFonkHesapla tp = new ToplamToplamFonkHesapla();
                    sonuc = tp.Toplamahesapla(parametre, dizi, agirlik);
                    break;
                case 2:
                    Console.WriteLine("Çarpım Toplama Fonksiyonu Seçildi");
                    CarpimToplamFonkHesaplama ca = new CarpimToplamFonkHesaplama();
                    sonuc = ca.Toplamahesapla(parametre, dizi, agirlik);
                    break;
                case 3:
                    MaxToplamFonkHesaplama max =new MaxToplamFonkHesaplama();
                    sonuc = max.Toplamahesapla(parametre, dizi, agirlik);
                    Console.WriteLine("Max Toplama Fonksiyonu Seçildi");
                    break;
                case 4:
                    MinToplamFonkHesaplama min = new MinToplamFonkHesaplama();
                    sonuc = min.Toplamahesapla(parametre, dizi, agirlik);
                    Console.WriteLine("Min Toplama Fonksiyonu Seçildi");
                    break;
                default:
                    Console.WriteLine("Yanlış seçim");
                    break;
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Aktivasyon(Etkinlik) Fonksiyonu Seçiniz --------------->");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sigmoid Aktivasyon(Etkinlik) Fonksiyonu için 1'i Seçiniz");
            Console.WriteLine("Hiperbolik Tanjant Aktivasyon(Etkinlik) Fonksiyonu için 2'i Seçiniz");
            Console.WriteLine("Adım Basamak Aktivasyon(Etkinlik) Fonksiyonu için 3'i Seçiniz");
            

            int caseSwitch2 = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch2)
            {
                case 1:
                    Console.WriteLine("Sigmoid Aktivasyon(Etkinlik) Fonksiyonu Seçildi");
                    SigmoidAktivasyon sm = new SigmoidAktivasyon();
                    Console.WriteLine("Ysa Hücre Çıkış Değeri   : "+sm.Aktivasyonhesapla(sonuc));
                    break;
                case 2:
                    Console.WriteLine("Hiperbolik Tanjant Aktivasyon(Etkinlik) Fonksiyonu Seçildi");
                    HiperbolikAktivasyon hb = new HiperbolikAktivasyon();
                    Console.WriteLine("Ysa Hücre Çıkış Değeri   : " + hb.Aktivasyonhesapla(sonuc));
                    break;
                case 3:
                    Console.WriteLine("Adım Basamak Aktivasyon(Etkinlik) Fonksiyonu Seçildi");
                    AdimBasamakAktivasyon ab = new AdimBasamakAktivasyon();
                    Console.WriteLine("Ysa Hücre Çıkış Değeri   : " + ab.Aktivasyonhesapla(sonuc));
                    break;
                default:
                    Console.WriteLine("Yanlış seçim");
                    break;
            }

            Console.ReadKey();

        }
    }
}
