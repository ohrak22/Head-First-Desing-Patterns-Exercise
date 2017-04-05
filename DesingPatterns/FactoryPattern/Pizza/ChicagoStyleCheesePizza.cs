using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class ChicagoStyleCheesePizza : Pizza
	{
		public ChicagoStyleCheesePizza()
		{
			name = "Chicago Style Cheese Pizza";
			dough = "Extra Thin Crust Dough";
			sauce = "Plum Tomato Sauce";

			Toppings.Add("Shreddad Mozzarella Cheese");
		}

		public override void cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
