using System;

namespace metotlar_overloading
{
    class program
    {
        static void Main(string[]args)
        {
            //out parametreler
            string sayi="999";

             bool sonuc = int.TryParse(sayi,out int outsayi);
             if(sonuc)
             {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outsayi);
             }
             else {
                 Console.WriteLine("Başarısız!");
            }

            metotlar_overloading instance = new metotlar_overloading();
            instance.Topla(4,5, out int  toplamsonucu);
            Console.WriteLine(toplamsonucu);

            // metot aşırı yükleme - overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("ceyhun");

            //Metot imzası
            //metotAdı + parametre sayisi + parametre
                

         }
      }

      class metotlar_overloading
      {
        public void Topla(int a,int b, out int toplam)
        { 
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        { 
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        { 
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(string veri1, string veri2)
        { 
            Console.WriteLine(veri1 + veri2);
        }
     }       
}