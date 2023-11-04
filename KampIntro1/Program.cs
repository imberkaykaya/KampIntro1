using System;

namespace KampIntro1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//type safety - tip güvenliği
			//Do not repeat yourself - Kendini tekrarlama
			//değer tutucu, alias

			string kategoriEtiketi = "Kategoriler Çokomelli";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.45;
			double dolarBugun = 7.45;

			Console.WriteLine(kategoriEtiketi); 

			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giriş yap butonu");
			}

			if (dolarDun > dolarBugun)
			{
				Console.WriteLine("Düşüş Oku");
			}
			else if(dolarDun < dolarBugun)
			{
				Console.WriteLine("Yükseliş Oku");
			}
			else
			{
				Console.WriteLine("Sabit Kaldı");
			}
		}
	}
}
