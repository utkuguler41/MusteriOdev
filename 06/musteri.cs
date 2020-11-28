using System;

namespace _06
{
    class Musteri {


     



        static void Main(string[] args)
        {
            Console.WriteLine("Öğrencimisiniz?   (Evet/Hayır)");
            string cevap = Console.ReadLine();
            if (cevap == "Evet")
            {
                ogrenci ogrenci = new ogrenci();
                ogrenci.ad = "Utku";
                ogrenci.soyad = "Güler";
                ogrenci.ogrno = 221903550;
                ogrenci.dogumyili = 2000;
                ogrenci.Yas = 20;

                Console.WriteLine(ogrenci.ad);
                Console.WriteLine(ogrenci.soyad);
                Console.WriteLine(ogrenci.ogrno);
                Console.WriteLine(ogrenci.dogumyili);
                Console.WriteLine(ogrenci.Yas);

            }
            else if (cevap == "Hayır")
            {
                ogrenci musteri = new ogrenci();
                musteri.ad = "Erdem";
                musteri.soyad = "Endeş";
                musteri.dogumyili = 1980;
                musteri.meslek = "Endüstri Mühendisi";
                musteri.maas = 25000;
                musteri.Yas = 40;


                Console.WriteLine(musteri.ad);
                Console.WriteLine(musteri.soyad);
                Console.WriteLine(musteri.dogumyili);
                Console.WriteLine(musteri.meslek);
                Console.WriteLine(musteri.maas);
                Console.WriteLine(musteri.Yas);



            }



        }
    }
}
