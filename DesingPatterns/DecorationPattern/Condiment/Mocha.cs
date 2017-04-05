using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	class Mocha : Beverage
	{
		Beverage beverage;

		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string Description
		{
			get
			{
				return beverage.Description + ", 모카";
			}
		}

		public override double cost()
		{
			return .20 + beverage.cost();
		}
	}
}
