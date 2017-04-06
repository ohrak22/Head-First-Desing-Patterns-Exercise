﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class LightOnCommand : Command
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		public void execute()
		{
			light.on();
		}

		public void undo()
		{
			light.off();
		}
	}
}
