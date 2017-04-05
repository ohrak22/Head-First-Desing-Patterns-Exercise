using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			SimplePizzaFactory factory = new SimplePizzaFactory();
			PizzaStore nyStore = new NYPizzaStore();
			PizzaStore chicagoStore = new ChicagoPizzaStore();

			Pizza pizza = factory.createPizza("pepperoni");
			Console.WriteLine("John ordered a " + pizza.name);
			Console.WriteLine("");

			pizza = nyStore.orderPizza("cheese");
			Console.WriteLine("Ethan ordered a " + pizza.name);
			Console.WriteLine("");

			pizza = chicagoStore.orderPizza("cheese");
			Console.WriteLine("Joel ordered a " + pizza.name);
			Console.WriteLine("");

		}
	}
}
