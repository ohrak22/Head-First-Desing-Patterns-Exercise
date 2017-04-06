using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	class Menu : MenuComponent
	{
		ArrayList menuComponents = new ArrayList();
		string name { get; set; }
		string description { get; set; }

		public Menu(string name, string description)
		{
			this.name = name;
			this.description = description;
		}

		public override void add(MenuComponent menuComponent)
		{
			menuComponents.Add(menuComponent);
		}
		public override void remove(MenuComponent menuComponent)
		{
			menuComponents.Remove(menuComponent);
		}

		public override MenuComponent getChild(int i)
		{
			return (MenuComponent)menuComponents[i];
		}

		public override void print()
		{
			Console.WriteLine(name + " " + description);
			IEnumerator enumerator = menuComponents.GetEnumerator();
			while(enumerator.MoveNext())
			{
				MenuComponent component = (MenuComponent)enumerator.Current;
				component.print();
			}
		}
	}
}
