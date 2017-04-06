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
			PizzaStore nyStore = new NYPizzaStore();
			PizzaStore chicagoStore = new ChicagoPizzaStore();

			Pizza pizza = nyStore.orderPizza("cheese");
			Console.WriteLine("Ethan ordered a " + pizza.name);
			Console.WriteLine("");

			pizza = chicagoStore.orderPizza("cheese");
			Console.WriteLine("Joel ordered a " + pizza.name);
			Console.WriteLine("");

		}
	}
}
