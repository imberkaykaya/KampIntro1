using System;

namespace Donguler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Array - Diziler
			string[] kurslar = new string[] {"Yazılım Geliştirici", "Programlamaya başlangıç için temel", "JAVA"};


			string name = "Saram";
			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}
			Console.WriteLine("---------------------");
            foreach (string kurs in kurslar)
            {
				Console.WriteLine(kurs);
            }
			Console.WriteLine("---------------------");
			Console.WriteLine("Sayfa Sonu");
        }
	}
}
