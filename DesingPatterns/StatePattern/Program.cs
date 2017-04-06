using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			GumballMachine gumballMachine = new GumballMachine(3);

			Console.WriteLine(gumballMachine.toString());

			gumballMachine.insertQuarter();
			gumballMachine.turnCrank();

			Console.WriteLine(gumballMachine.toString());

			gumballMachine.insertQuarter();
			gumballMachine.turnCrank();
			gumballMachine.insertQuarter();
			gumballMachine.turnCrank();

			Console.WriteLine(gumballMachine.toString());

			gumballMachine.insertQuarter();
			gumballMachine.turnCrank();


		}
	}
}
