using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class VeggiePizza : Pizza
	{
		public VeggiePizza()
		{
			name = "Veggie Pizza";
			dough = "Thin Dough";
			sauce = "Tomato Sauce";

			Toppings.Add("Veggie");
		}
	}
}
