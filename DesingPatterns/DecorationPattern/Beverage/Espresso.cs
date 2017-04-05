using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	class Espresso : Beverage
	{
		public Espresso()
		{
			Description = "에스프레소";
		}

		public override double cost()
		{
			return 1.99;
		}
	}
}
