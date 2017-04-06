using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class NoQuarterState : State
	{
		GumballMachine gumballMachine;

		public NoQuarterState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void insertQuarter()
		{
			Console.WriteLine("insertQuarter");
			gumballMachine.setState(gumballMachine.hasQuarterState);
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
			Console.WriteLine("dispense");
		}
	}
}
