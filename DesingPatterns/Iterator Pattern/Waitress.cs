using System;
using System.Collections;
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
			IEnumerator pancakeIterator = pancakeHouseMenu.createiterator();
			IEnumerator dinerIterator = dinerMenu.createiterator();
			Console.WriteLine("Menu\n----Morning menu----");
			printmenu(pancakeIterator);
			Console.WriteLine("\n----Diner menu----");
			printmenu(dinerIterator);
		}

		private void printmenu(IEnumerator iterator)
		{
			while(iterator.MoveNext())
			{
				if(iterator.Current != null)
				{
					MenuItem menuItem = (MenuItem)iterator.Current;
					Console.WriteLine(menuItem.name + ", " + menuItem.price + " -- " + menuItem.description);
				}
			}
		}
	}
}
