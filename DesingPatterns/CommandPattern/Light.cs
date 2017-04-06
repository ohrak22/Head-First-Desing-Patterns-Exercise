using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class Light
	{
		private string place;

		public Light(string place)
		{
			this.place = place;
		}

		public void on()
		{
			Console.WriteLine("Light is On");
		}

		public void off()
		{
			Console.WriteLine("Light is Off");
		}
	}
}
