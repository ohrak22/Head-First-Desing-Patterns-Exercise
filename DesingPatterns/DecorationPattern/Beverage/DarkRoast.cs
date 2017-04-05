using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationPattern
{
	class DarkRoast : Beverage
	{
		public DarkRoast()
		{
			Description = "다크 로스트";
			Console.WriteLine(Description);
		}

		public override double cost()
		{
			return .99;
		}
	}
}
