using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			GumballMachine machine = new GumballMachine("Bail", 5, "Sold");
			GumballMonitor monitor = new GumballMonitor(machine);

			monitor.report();
		}
	}
}
