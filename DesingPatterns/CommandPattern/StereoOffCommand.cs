using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class StereoOffCommand : Command
	{
		Stereo stereo;

		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void execute()
		{
			stereo.off();
		}

		public void undo()
		{
		}
	}
}
