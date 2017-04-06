using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	class MenuItem : MenuComponent
	{
		string name { get; set; }
		string description { get; set; }
		bool vegetarian { get; set; }
		double price { get; set; }

		public MenuItem(string name, string description, bool vegetarian, double price)
		{
			this.name = name;
			this.description = description;
			this.vegetarian = vegetarian;
			this.price = price;
		}

		public override void print()
		{
			string str = "  " + name;
			if(vegetarian)
				str += "(v)";
			str += ", " + price;
			str += " -- " + description;

			Console.WriteLine(str);
		}
	}
}
