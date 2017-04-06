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
			Console.WriteLine("insertQuarter");
			gumballMachine.setState(gumballMachine.hasQuarterState);
		}
		public void ejectQuarter()
		{
			Console.WriteLine("ejectQuarter");
			gumballMachine.setState(gumballMachine.noQuarterState);
		}
		public void turnCrank()
		{
			Console.WriteLine("turnCrank");
			gumballMachine.setState(gumballMachine.noQuarterState);
		}
		public void dispense()
		{
			Console.WriteLine("dispense");
			gumballMachine.setState(gumballMachine.noQuarterState);
		}
	}
}
