using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            //type safety-tip güvenli dil

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;

            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalma butonu");
            }
            else if(dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }





           if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
