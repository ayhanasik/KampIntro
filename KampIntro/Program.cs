using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = false;
            
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarBugun>dolarDun)
            {
               Console.WriteLine("Artış butonu");
            } 
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Düşüş butonu");
            }else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmismi == true)
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
