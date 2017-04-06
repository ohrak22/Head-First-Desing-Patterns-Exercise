using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class DinerMenu
	{
		static int MAX_ITEMS = 6;
		int numberOfItems = 0;
		MenuItem[] menuItems;

		public DinerMenu()
		{
			menuItems = new MenuItem[MAX_ITEMS];

			addItem("Vegerarian BLT", "lettuce, tomato", true, 2.99);
			addItem("BLT", "bacon, lettuce, tomato", false, 2.99);
			addItem("Soup", "potato", false, 3.29);
			addItem("Hot dog", "onion, cheese", false, 3.05);
		}

		public void addItem(string name, string description, bool vegerarian, double price)
		{
			MenuItem menuItem = new MenuItem(name, price, description);
			if(numberOfItems >= MAX_ITEMS)
			{
				Console.WriteLine("Sorry. menu is full.");
			}
			else
			{
				menuItems[numberOfItems] = menuItem;
				numberOfItems++;
			}
		}

		public Iterator createiterator()
		{
			return new DinerMenuIterator(menuItems);
		}

	}
}
