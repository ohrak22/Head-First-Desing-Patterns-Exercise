using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class ChicagoPizzaStore : PizzaStore
	{
		public override Pizza createPizza(string type)
		{
			Pizza pizza = null;
			PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

			if(type.Equals("cheese"))
			{
				pizza = new ChicagoStyleCheesePizza(ingredientFactory);
				pizza.name = "Chicago Style Cheese Pizza";
			}
			else if(type.Equals("pepperoni"))
			{
				pizza = new PepperoniPizza(ingredientFactory);
				pizza.name = "Chicago Style Pepperoni Pizza";
			}
			else if(type.Equals("clam"))
			{
				pizza = new ClamPizza(ingredientFactory);
				pizza.name = "Chicago Style Clam Pizza";
			}
			else if(type.Equals("veggie"))
			{
				pizza = new VeggiePizza(ingredientFactory);
				pizza.name = "Chicago Style Veggie Pizza";
			}

			return pizza;
		}
	}
}
