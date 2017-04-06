using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMathodPattern
{
	class Tea : CaffeineBeverage
	{
		public override void brew()
		{
			Console.WriteLine("Brew tea bag");
		}

		public override void addCondiments()
		{
			Console.WriteLine("Add lemon");
		}
	}
}
