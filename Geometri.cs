using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7
{
	//Abstrakt geometri-klass, parent-klass till olika geometriska former
	internal abstract class Geometri
	{
		//Abstract metod för att räkna ut arean för child-klassers former
		public abstract double Area();
	}
}
