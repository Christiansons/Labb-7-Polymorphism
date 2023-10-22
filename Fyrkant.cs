using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	internal class Fyrkant : Geometri
	{
        //Property för sidan på en fyrkant
		public double side {  get; set; }

        //Konstruktor som initerar ett fyrkants-objekt med en sidans längd
        public Fyrkant(double side)
        {
            this.side = side;
        }
        //Overridden metod för att räkna ut arean på en fyrkant
        public override double Area()
        {
            return side * side;
        }
    }
}
