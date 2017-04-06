using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class RemoteControl
	{
		Command[] onCommands;
		Command[] offCommands;

		public RemoteControl()
		{
			onCommands = new Command[7];
			offCommands = new Command[7];

			Command noCommand = new NoCommand();

			for(int i = 0; i < 7; i++)
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
		}

		public void setCommand(int slot, Command onCommand, Command offComman)
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offComman;
		}

		public void onButtonWasPushed(int slot)
		{
			onCommands[slot].execute();
		}

		public void offButtonWasPushed(int slot)
		{
			offCommands[slot].execute();
		}

		public string toString()
		{
			string str = "";
			str += "------ Remote Control ------\n";
			for(int i = 0; i < onCommands.Length; i++)
			{
				str += "[slot " + i + "] " + onCommands[i].GetType().Name + " " + onCommands[i] + "\n";
			}
			return str;
		}
	}
}
