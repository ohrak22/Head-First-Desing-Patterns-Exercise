using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class MenuItem
	{
		public MenuItem(string name, double price, string description)
		{
			this.name = name;
			this.price = price;
			this.description = description;
		}

		public string name { get; set; }
		public double price { get; set; }
		public string description { get; set; }
	}
}
