using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
	class WildTurkey : Turkey
	{
		public void gobble()
		{
			Console.WriteLine("Gobble gobble");
		}

		public void fly()
		{
			Console.WriteLine("I'm flying a short distance");
		}
	}
}
