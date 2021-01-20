using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MüşterininAdı = "Ali";
            musteri1.Soyadı = "Yılmaz";
            musteri1.DoğumTarihi = "21.11.1996";
            musteri1.DoğumYeri = "Kayseri";
            musteri1.MedeniDurum = "Bekar";
            musteri1.Uyruk = "Türk";

            Musteri musteri2 = new Musteri();
            musteri2.MüşterininAdı = "Burak";
            musteri2.Soyadı = "Yılmaz";
            musteri2.DoğumTarihi = "11.11.1993";
            musteri2.DoğumYeri = "İstanbul";
            musteri2.MedeniDurum = "Bekar";
            musteri2.Uyruk = "Türk";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();


            musteriManager.MusteriEkle(musteri2);


            Console.WriteLine("-------------------------");

            musteriManager.MusteriyiSil(musteri1);


            Console.WriteLine("---------------------");



        }
    }
}
