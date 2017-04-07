using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
	class Flock : Quackable
	{
		ArrayList quackers = new ArrayList();

		public void add(Quackable quacker)
		{
			quackers.Add(quacker);
		}

		public void quack()
		{
			IEnumerator iterator = quackers.GetEnumerator();
			while(iterator.MoveNext())
			{
				Quackable quacker = (Quackable)iterator.Current;
				quacker.quack();
			}
		}
	}
}
