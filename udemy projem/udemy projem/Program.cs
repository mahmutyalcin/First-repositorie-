/*
 * Created by SharpDevelop.
 * User: MAHMUT YALÇIN
 * Date: 3.04.2023
 * Time: 02:50
 */
using System;

namespace udemy_projem
{
	class Program
	{
		public static void Main(string[] args)
		{
		//Kodlar
			int maas = 0;
			int mutfakGideri=0;
			int elektrikGideri=0;			
			int suGideri=0;
			int telefonGideri=0;
			int internet=0;
			int giyim=0;
			int diger=0;
			Console.ForegroundColor= ConsoleColor.Cyan;
			Console.WriteLine("Maaş Giriniz =");
			string okunanDeger=Console.ReadLine();
			maas= Convert.ToInt32(okunanDeger);
			Console.WriteLine("Mutfak Gideri Giriniz =");
			mutfakGideri= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Elektrik Gideri Giriniz =");
			elektrikGideri= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Su Gideri Giriniz =");
			suGideri= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Telefon Gideri Giriniz =");
			telefonGideri= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("İnternet Gideri Giriniz =");
			internet= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Giyim Gideri Giriniz =");
			giyim= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Diğer Gideri Giriniz =");
			diger= Convert.ToInt32(Console.ReadLine());
			int sonuc = maas-mutfakGideri-elektrikGideri-suGideri-telefonGideri-internet-giyim-diger;
			Console.WriteLine("\r\n Cebimizde Kalan Para : " + sonuc);
			Console.ReadLine();
		}
	}
}