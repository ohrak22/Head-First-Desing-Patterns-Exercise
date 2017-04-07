using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			DuckSimulator simulator = new DuckSimulator();
			AbstractDuckFactory factory = new CountingDuckFactory();

			simulator.simulate(factory);
		}
	}
}
