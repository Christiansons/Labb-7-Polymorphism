using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	internal class Cirkel : Geometri
	{
        //Property för att räkna ut cirkels area
		public double radius {  get; set; }

        //Konstruktor som initierar ett cirkel-objekt med en radius
        public Cirkel(double radius)
        {
           this.radius = radius;
        }

        //Overridden metod för att räkna ut araen för en cirkel
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
