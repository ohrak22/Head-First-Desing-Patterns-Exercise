using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Amplifier amp = new Amplifier();
			Tuner tuner = new Tuner();
			DvdPlayer dvd = new DvdPlayer();
			CdPlayer cd = new CdPlayer();
			Projector projector = new Projector();
			TheaterLights lights = new TheaterLights();
			Screen screen = new Screen();
			PopcornPopper popper = new PopcornPopper();

			HomeTheaterFacad homeTheater = new HomeTheaterFacad(amp, tuner, dvd, cd, projector, lights, screen, popper);

			homeTheater.watchMovie("Raiders of the Lost Ark");
			homeTheater.endMovie();
		}
	}
}
