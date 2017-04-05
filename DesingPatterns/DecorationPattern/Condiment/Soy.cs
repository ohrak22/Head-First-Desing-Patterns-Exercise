using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern.Condiment
{
	class Soy : Beverage
	{
		Beverage beverage;

		public Soy(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string Description
		{
			get
			{
				return beverage.Description + ", 두유";
			}
		}

		public override double cost()
		{
			return .15 + beverage.cost();
		}
	}
}
