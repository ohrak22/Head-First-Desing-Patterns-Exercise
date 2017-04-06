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
			Console.WriteLine("알맹이가 나가고 있습니다.");
		}
		public void ejectQuarter()
		{
			Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
		}
		public void turnCrank()
		{
			Console.WriteLine("손잡이는 한번만 돌려주세요.");
		}
		public void dispense()
		{
			Console.WriteLine("알맹이가 나가고 있습니다.");
			gumballMachine.releaseBall();
			if(gumballMachine.getCount() > 0)
			{
				gumballMachine.setState(gumballMachine.noQuarterState);
			}
			else
			{
				gumballMachine.setState(gumballMachine.soldOutState);
			}
		}
	}
}
