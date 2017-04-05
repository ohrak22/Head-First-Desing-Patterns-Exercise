using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class PepperoniPizza : Pizza
	{
		public PepperoniPizza()
		{
			name = "Pepperoni Pizza";
			dough = "Thin Dough";
			sauce = "Tomato Sauce";

			Toppings.Add("Pepperoni");
		}
	}
}
