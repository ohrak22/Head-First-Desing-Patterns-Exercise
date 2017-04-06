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
			state.dispense();
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
			state = noQuarterState;
		}
		public void setState(State state)
		{
			this.state = state;
		}

		public void releaseBall()
		{
			count--;
		}

		public int getCount()
		{
			return count;
		}

		public string toString()
		{
			string str = "\n주식회사 왕뽑기";
			str += "\n남은 개수: " + count + "개";
			return str;
		}

	}
}
