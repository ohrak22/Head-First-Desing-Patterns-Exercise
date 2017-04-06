using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	class MenuComponent
	{
		public virtual void add(MenuComponent menuComponent)
		{
		}
		public virtual void remove(MenuComponent menuComponent)
		{
		}
		public virtual MenuComponent getChild(int i)
		{
			throw new Exception();
		}
		
		public virtual void print()
		{
		}
	}
}
