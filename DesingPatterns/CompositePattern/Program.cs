using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			MenuComponent pancakeMenu = new Menu("Pancake Menu", " - morning menu");
			MenuComponent dinerMenu = new Menu("Diner Menu", " - diner menu");
			MenuComponent cafeMenu = new Menu("Cafe Menu", " - every time");

			MenuComponent allMenus = new Menu("All Menu", " - all menu");
			allMenus.add(pancakeMenu);
			allMenus.add(dinerMenu);
			allMenus.add(cafeMenu);

			dinerMenu.add(new MenuItem("BLT", "bacon, lettuce, tomato", false, 3.89));
			pancakeMenu.add(new MenuItem("Apple pancake", "Apple", true, 1.59));
			cafeMenu.add(new MenuItem("Coffee", "Coffee", false, 0.99));

			Waitress waitress = new Waitress(allMenus);
			waitress.printMenu();
			
		}
	}
}
