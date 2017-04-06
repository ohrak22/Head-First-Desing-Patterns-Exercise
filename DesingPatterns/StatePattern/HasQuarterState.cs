using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class HasQuarterState : State
	{
		GumballMachine gumballMachine;

		public HasQuarterState(GumballMachine gumballMachine)
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
		}
	}
}
