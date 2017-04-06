using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class SoldOutState : State
	{
		GumballMachine gumballMachine;

		public SoldOutState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void insertQuarter()
		{
			Console.WriteLine("매진 되었습니다. 동전이 반환됩니다.");
		}
		public void ejectQuarter()
		{
			Console.WriteLine("죄송합니다. 매진 되었습니다.");
		}
		public void turnCrank()
		{
			Console.WriteLine("죄송합니다. 매진 되었습니다.");
		}
		public void dispense()
		{
			Console.WriteLine("죄송합니다. 매진 되었습니다.");
		}
	}
}
