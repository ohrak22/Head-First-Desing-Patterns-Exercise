using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class PancakeHouseMenu
	{
		ArrayList menuItems;

		public PancakeHouseMenu()
		{
			menuItems = new ArrayList();
			addItem("K&B Pancake", "Eggs and toast", false, 2.99);
			addItem("Regular Pancake", "Eggs and sausage", false, 2.99);
			addItem("Blueberry Pancake", "Blueberry", false, 3.99);
			addItem("Waffle", "Waffle", false, 4.99);


		}

		public void addItem(string name, string description, bool vegerarian, double price)
		{
			MenuItem menuItem = new MenuItem(name, price, description);
			menuItems.Add(menuItem);
		}

		public Iterator createiterator()
		{
			return new PancakeHouseIterator(menuItems);
		}
	}
}
