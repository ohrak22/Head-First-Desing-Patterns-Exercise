using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class CheesePizza : Pizza
	{
		public CheesePizza()
		{
			name = "Cheese Pizza";
			dough = "Thin Dough";
			sauce = "Tomato Sauce";

			Toppings.Add("Cheese");
		}
	}
}
