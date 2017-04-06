﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class LightOffCommand : Command
	{
		Light light;

		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		public void execute()
		{
			light.off();
		}
	}
}
