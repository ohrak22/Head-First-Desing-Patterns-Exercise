using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class NYPizzaStore : PizzaStore
	{
		public override Pizza createPizza(string type)
		{
			Pizza pizza = null;
			PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

			if(type.Equals("cheese"))
			{
				pizza = new NYStyleCheesePizza(ingredientFactory);
				pizza.name = "New York Style Cheese Pizza";
			}
			else if(type.Equals("pepperoni"))
			{
				pizza = new PepperoniPizza(ingredientFactory);
				pizza.name = "New York Style Pepperoni Pizza";
			}
			else if(type.Equals("clam"))
			{
				pizza = new ClamPizza(ingredientFactory);
				pizza.name = "New York Style Clam Pizza";
			}
			else if(type.Equals("veggie"))
			{
				pizza = new VeggiePizza(ingredientFactory);
				pizza.name = "New York Style Veggie Pizza";
			}

			return pizza;
		}
	}
}
