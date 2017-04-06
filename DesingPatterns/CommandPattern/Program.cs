using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-----------SimpleRemoteControl-------------");
			SimpleRemoteControl remote = new SimpleRemoteControl();
			Light light = new Light("Light");
			LightOnCommand lightOn = new LightOnCommand(light);

			remote.setCommand(lightOn);
			remote.buttonWasPressed();

			Console.WriteLine("");

			RemoteControl remotControl = new RemoteControl();

			Light livingRoomLight = new Light("Living Room");
			Light kitchenLight = new Light("Kitchen");
			Stereo stereo = new Stereo("Living Room");

			LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

			LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
			LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

			StereoOnWithCDCommand StereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
			StereoOffCommand StereoOffCommand = new StereoOffCommand(stereo);

			remotControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
			remotControl.setCommand(1, kitchenLightOn, kitchenLightOff);
			remotControl.setCommand(2, StereoOnWithCDCommand, StereoOffCommand);

			Console.WriteLine(remotControl.toString());

			remotControl.onButtonWasPushed(0);
			remotControl.offButtonWasPushed(0);
			remotControl.onButtonWasPushed(1);
			remotControl.offButtonWasPushed(1);
			remotControl.onButtonWasPushed(2);
			remotControl.offButtonWasPushed(2);


			Console.WriteLine("");

			RemoteControlWithUndo undoRemotControl = new RemoteControlWithUndo();

			Light livingRoomUndoLight = new Light("Living Room");

			LightOnCommand livingRoomUndoLightOn = new LightOnCommand(livingRoomUndoLight);
			LightOffCommand livingRoomUndoLightOff = new LightOffCommand(livingRoomUndoLight);

			undoRemotControl.setCommand(0, livingRoomUndoLightOn, livingRoomUndoLightOff);

			undoRemotControl.onButtonWasPushed(0);
			undoRemotControl.offButtonWasPushed(0);
			Console.WriteLine(undoRemotControl.toString());

			undoRemotControl.undoButtonWasPushed();
			undoRemotControl.onButtonWasPushed(0);
			undoRemotControl.offButtonWasPushed(0);
			Console.WriteLine(undoRemotControl.toString());

			undoRemotControl.undoButtonWasPushed();
		}
	}
}
