﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class SimpleRemoteControl
	{
		Command slot;

		public SimpleRemoteControl()
		{
		}

		public void setCommand(Command command)
		{
			slot = command;
		}

		public void buttonWasPressed()
		{
			slot.execute();
		}
	}
}
