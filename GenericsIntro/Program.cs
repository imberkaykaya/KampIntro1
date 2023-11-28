using System;

namespace GenericsIntro
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyList<string> isimler = new MyList<string>();
			isimler.Add("Berkay");

            Console.WriteLine(isimler.Length);

			isimler.Add("Sasa");

            Console.WriteLine(isimler.Length);

			foreach (var isim in isimler.Items)
			{
				Console.WriteLine(isim);
            }
        }
	}
}
