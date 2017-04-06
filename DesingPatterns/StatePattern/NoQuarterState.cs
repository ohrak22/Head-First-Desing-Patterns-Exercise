﻿using System;
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
			Console.WriteLine("동전을 넣으셨습니다.");
			gumballMachine.setState(gumballMachine.hasQuarterState);
		}
		public void ejectQuarter()
		{
			Console.WriteLine("동전을 넣어주세요.");
		}
		public void turnCrank()
		{
			Console.WriteLine("동전을 넣어주세요.");
		}
		public void dispense()
		{
			Console.WriteLine("동전을 넣어주세요.");
		}
	}
}
