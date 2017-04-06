using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class SoldState : State
	{
		GumballMachine gumballMachine;

		public SoldState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void insertQuarter()
		{
			Console.WriteLine("insertQuarter");
		}
		public void ejectQuarter()
		{
			Console.WriteLine("ejectQuarter");
		}
		public void turnCrank()
		{
			Console.WriteLine("turnCrank");
		}
		public void dispense()
		{
			gumballMachine.releaseBall();
			if(gumballMachine.getCount() > 0)
			{
				gumballMachine.setState(gumballMachine.noQuarterState);
			}
			else
			{
				Console.WriteLine("Oops, out of gumballs!");
				gumballMachine.setState(gumballMachine.soldOutState);
			}
		}
	}
}
