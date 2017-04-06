using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class Waitress
	{
		PancakeHouseMenu pancakeHouseMenu;
		DinerMenu dinerMenu;

		public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
		{
			this.pancakeHouseMenu = pancakeHouseMenu;
			this.dinerMenu = dinerMenu;
		}

		public void printMenu()
		{
			Iterator pancakeIterator = pancakeHouseMenu.createiterator();
			Iterator dinerIterator = dinerMenu.createiterator();
			Console.WriteLine("Menu\n----Morning menu----");
			printmenu(pancakeIterator);
			Console.WriteLine("\n----Diner menu----");
			printmenu(dinerIterator);
		}

		private void printmenu(Iterator iterator)
		{
			while(iterator.hasNext())
			{
				MenuItem menuItem = (MenuItem)iterator.next();
				Console.WriteLine(menuItem.name + ", " + menuItem.price + " -- " + menuItem.description);
			}
		}
	}
}
