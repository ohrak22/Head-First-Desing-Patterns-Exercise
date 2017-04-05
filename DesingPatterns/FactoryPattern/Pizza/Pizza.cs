using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class Pizza
	{
		public string name { get; set; }
		public string dough { get; set; }
		public string sauce { get; set; }
		private ArrayList toppings = new ArrayList();
		public ArrayList Toppings
		{
			get { return toppings; }
			set { toppings = value; }
		}

		public virtual void prepare()
		{
			Console.WriteLine("Preparing " + name);
			Console.WriteLine("Tossing dough " + dough);
			Console.WriteLine("Adding sauce...");
			string toppingStr = "Adding toppings:";
			for(int i = 0; i < toppings.Count; i++)
			{
				toppingStr += " " + toppings[i];
			}
			Console.WriteLine(toppingStr);
		}
		public virtual void bake()
		{
			Console.WriteLine("Back for 25 minutes at 350");
		}
		public virtual void cut()
		{
			Console.WriteLine("Cutting the pizza into diagonal slices");
		}
		public virtual void box()
		{
			Console.WriteLine("Place pizza in official PizzaStore box");
		}

	}
}
