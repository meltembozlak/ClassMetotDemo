using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Bu müşteriyi eklemek istiyor musunuz? : " + musteri.MüşterininAdı + musteri.Soyadı + musteri.DoğumTarihi + musteri.DoğumYeri + musteri.MedeniDurum + musteri.Uyruk);
        }

        public void MusteriyiSil(Musteri musteri)
        {
            Console.WriteLine("Bu Müşteriyi Silmek İstiyor musunuz? : " + musteri.MüşterininAdı + musteri.Soyadı + musteri.DoğumTarihi + musteri.DoğumYeri + musteri.MedeniDurum + musteri.Uyruk);
        }
    }
}
