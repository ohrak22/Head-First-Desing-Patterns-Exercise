using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	class GumballMachine
	{
		string location;
		int count;
		string state;

		public GumballMachine(string location, int count, string state)
		{
			this.location = location;
			this.count = count;
			this.state = state;
		}

		public string getLocation()
		{
			return location;
		}
		public int getCount()
		{
			return count;
		}
		public string getState()
		{
			return state;
		}

	}
}
