using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	internal class Rektangel : Geometri
	{
		//Properties för en rektangels sidor
        public double side1 {  get; set; }
		public double side2 { get; set; }

		//konstruktor som intierar ett rektangel-objekt med sidornas längder
		public Rektangel(double side1, double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
		}

		//Overridden metod för att räkna ut area på en rektangel
		public override double Area()
		{
			return side1 * side2;
		}
	}
}
