using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	class Whip : Beverage
	{
		Beverage beverage;

		public Whip(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string Description
		{
			get
			{
				return beverage.Description + ", 휘핑 크림";
			}
		}

		public override double cost()
		{
			return .10 + beverage.cost();
		}
	}
}
