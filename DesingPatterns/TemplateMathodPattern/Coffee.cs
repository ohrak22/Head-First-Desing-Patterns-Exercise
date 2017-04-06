using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMathodPattern
{
	class Coffee : CaffeineBeverage
	{
		public override void brew()
		{
			Console.WriteLine("Brew coffee grinds");
		}

		public override void addCondiments()
		{
			Console.WriteLine("Add sugar and milk");
		}
	}
}
