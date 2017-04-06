using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMathodPattern
{
	abstract class CaffeineBeverage
	{
		public void prepareRecipe()
		{
			boilWater();
			brew();
			pourInCup();
			addCondiments();
		}

		public abstract void brew();
		public abstract void addCondiments();

		public void boilWater()
		{
			Console.WriteLine("Boil warter");
		}

		public void pourInCup()
		{
			Console.WriteLine("Pour in cup");
		}

	}
}
