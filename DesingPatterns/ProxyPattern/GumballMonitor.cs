using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	class GumballMonitor
	{
		GumballMachine machine;

		public GumballMonitor(GumballMachine machine)
		{
			this.machine = machine;
		}

		public void report()
		{
			Console.WriteLine(machine.getLocation());
			Console.WriteLine(machine.getCount());
			Console.WriteLine(machine.getState());
		}
	}
}
