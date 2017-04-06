using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMathodPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Tea myTea = new Tea();
			myTea.prepareRecipe();

			Coffee myCoffee = new Coffee();
			myCoffee.prepareRecipe();
		}
	}
}
