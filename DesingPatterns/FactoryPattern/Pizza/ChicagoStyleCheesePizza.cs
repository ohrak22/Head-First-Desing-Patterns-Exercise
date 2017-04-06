using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class ChicagoStyleCheesePizza : Pizza
	{
		PizzaIngredientFactory ingredientFactory;

		public ChicagoStyleCheesePizza(PizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		public override void prepare()
		{
			Console.WriteLine("Preparing " + name);
			dough = ingredientFactory.createDough();
			sauce = ingredientFactory.createSauce();
			cheese = ingredientFactory.createCheese();
		}

		public override void cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
