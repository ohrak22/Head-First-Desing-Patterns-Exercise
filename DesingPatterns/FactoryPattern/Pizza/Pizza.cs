using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	abstract class Pizza
	{
		public string name { get; set; }
		public Dough dough;
		public Sauce sauce;
		public Veggies[] veggies;
		public Cheese cheese;
		public Pepperoni pepperoni;
		public Clam clam;

		public abstract void prepare();

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

		public string ToString()
		{
			return "없음";
		}

	}
}
