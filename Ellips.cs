using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	//Ellips-klassen som ärver från geometri-klassen
	internal class Ellips : Geometri
	{
        //Ellips properties som behövs för att räkna ut area
        public double StorAxel { get; set; }
		public double LillAxel { get; set; }

		//Konstruktor som initierar objekt av Ellips
		public Ellips(double storAxel, double lillAxel) 
		{
			StorAxel = storAxel;
			LillAxel = lillAxel;
		}
		
		//Metod för att räkna ut area, overrided för att räkna ut för en ellips
		public override double Area()
		{
			return LillAxel * StorAxel * Math.PI;
		}

	}
}
