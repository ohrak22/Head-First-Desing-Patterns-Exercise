using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	//class PizzaStore
	abstract class PizzaStore
	{
		//SimplePizzaFactory factory;

		//public PizzaStore(SimplePizzaFactory factory)
		//{
		//	this.factory = factory;
		//}

		public Pizza orderPizza(string type)
		{
			Pizza pizza;

			//pizza = factory.createPizza(type);
			pizza = createPizza(type);

			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();

			return pizza;
		}

		public abstract Pizza createPizza(string type);
	}
}
