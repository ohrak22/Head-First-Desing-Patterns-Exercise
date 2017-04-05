using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class NYStyleCheesePizza : Pizza
	{
		public NYStyleCheesePizza()
		{
			name = "NY Style Cheese Pizza";
			dough = "Thin Crust Dough";
			sauce = "Marinara Sauce";

			Toppings.Add("Grated Reggiano Cheese");
		}
	}
}
