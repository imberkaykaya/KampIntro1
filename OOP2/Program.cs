using System;

namespace OOP2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.Id = 1;
			musteri1.MusteriNo = "12345";
			musteri1.Adi = "Berkay";
			musteri1.Soyadi = "Kaya";
			musteri1.TcNo = "99999999999";

			//Kodlama.io 

			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 2;
			musteri2.MusteriNo = "54321";
			musteri2.SirketAdi = "Kodlama";
			musteri2.VergiNo = "112299";


			//Gerçek Müşteri - Tüzel Müşteri
			//SOLID

			//referans no.
			Musteri musteri3 = new GercekMusteri();
			Musteri musteri4 = new TuzelMusteri();

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);
			musteriManager.Ekle(musteri2);
		}
	}
}
