using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	internal class Parallellogram : Geometri
	{
        //Properties som behövs för att räkna ut area på Parallellogram
		public double Height {  get; set; }
		public double Base { get; set; }

        //Konstruktor som initierar ett parallellogram-objekt med nödvändiga properties för att räkna ut area
        public Parallellogram(double height, double Base)
        {
            Height = height;
            this.Base = Base;
        }

        //Overridden metod för att räkna ut area för ett parallellogram
        public override double Area()
        {
            return Height * Base;
        }
    }
}
