using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class Stereo
	{
		private string place;

		public Stereo(string place)
		{
			this.place = place;
		}

		public void on()
		{
			Console.WriteLine("Stereo is On");
		}

		public void off()
		{
			Console.WriteLine("Stereo is Off");
		}

		public void setCD()
		{
			Console.WriteLine("Stereo set CD");
		}

		public void setVolume(int volume)
		{
			Console.WriteLine("Stereo volume: " + volume);
		}


	}
}
