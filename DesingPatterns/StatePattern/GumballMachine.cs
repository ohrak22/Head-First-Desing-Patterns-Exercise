using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class GumballMachine
	{
		public State soldOutState { get; set; }
		public State noQuarterState { get; set; }
		public State hasQuarterState { get; set; }
		public State soldState { get; set; }

		public void insertQuarter()
		{
			state.insertQuarter();
		}

		public void turnCrank()
		{
			state.turnCrank();
		}
		public void ejectQuarter()
		{
			state.ejectQuarter();
		}

		public void dispense()
		{
			state.dispense();
		}


		State state;
		int count = 0;

		public GumballMachine(int numberGumballs)
		{
			count = numberGumballs;
			soldOutState = new SoldOutState(this);
			noQuarterState = new NoQuarterState(this);
			hasQuarterState = new HasQuarterState(this);
			soldState = new SoldState(this);
			state = soldState;
		}
		public void setState(State state)
		{
			this.state = state;
		}

		public void releaseBall()
		{
		}

		public int getCount()
		{
			return count;
		}
	}
}
