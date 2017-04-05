using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class ClamPizza : Pizza
	{
		public ClamPizza()
		{
			name = "Clame Pizza";
			dough = "Thin Dough";
			sauce = "Tomato Sauce";

			Toppings.Add("Clame");
		}
	}
}
