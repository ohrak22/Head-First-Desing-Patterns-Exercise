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
			Console.WriteLine("동전은 한 개만 넣어주세요.");
		}
		public void ejectQuarter()
		{
			Console.WriteLine("동전이 반환됩니다.");
			gumballMachine.setState(gumballMachine.noQuarterState);
		}
		public void turnCrank()
		{
			Console.WriteLine("손잡이를 돌렸습니다.");
			gumballMachine.setState(gumballMachine.soldState);
		}
		public void dispense()
		{
			Console.WriteLine("알맹이가 나갈 수 없습니다.");
		}
	}
}
