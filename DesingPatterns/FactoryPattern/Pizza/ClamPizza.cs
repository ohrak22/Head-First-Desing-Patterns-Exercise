using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class ClamPizza : Pizza
	{
		PizzaIngredientFactory ingredientFactory;

		public ClamPizza(PizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		public override void prepare()
		{
			Console.WriteLine("Preparing " + name);
			dough = ingredientFactory.createDough();
			sauce = ingredientFactory.createSauce();
			cheese = ingredientFactory.createCheese();
			clam = ingredientFactory.createClam();
		}
	}
}
