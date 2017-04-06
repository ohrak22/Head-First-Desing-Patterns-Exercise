using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class StereoOnWithCDCommand : Command
	{
		Stereo stereo;

		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void execute()
		{
			stereo.on();
		}
	}
}
