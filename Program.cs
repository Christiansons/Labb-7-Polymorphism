using System.Drawing;

namespace Labb_7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			//initerar objekt av alla former med respektive konstruktor
			Geometri ellips = new Ellips(5, 3);
			Geometri rektangel = new Rektangel(10, 5);
			Geometri fyrkant = new Fyrkant(5);
			Geometri cirkel = new Cirkel(5);
			Geometri parallellogram = new Parallellogram(7, 6);

			//Skriver ut area för varje objekt med hjälp av Area()-metoden
			Console.WriteLine($"Area för cirkel: {cirkel.Area()}");
			Console.WriteLine($"Area för ellips: {ellips.Area()}");
			Console.WriteLine($"Area för fyrkant: {fyrkant.Area()}");
			Console.WriteLine($"Area för rektangel: {rektangel.Area()}");
			Console.WriteLine($"Area för parallellogram: {parallellogram.Area()}");
		}
	}
}