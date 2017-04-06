using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
	class Amplifier
	{
		public void on()
		{
		}

		public void setDvd(DvdPlayer dvd)
		{
		}

		public void setSurroundSound()
		{
		}

		public void setVolume(int v)
		{
		}

		public void off()
		{
		}
	}
	class Tuner
	{
	}
	class DvdPlayer
	{
		public void on()
		{
		}

		public void play(string movie)
		{
			Console.WriteLine("Play " + movie);
		}

		public void stop()
		{
			Console.WriteLine("Stop DVD");
		}

		public void eject()
		{
		}

		public void off()
		{
			Console.WriteLine("Off DVD");
		}
	}
	class CdPlayer
	{
	}
	class Projector
	{
		public void on()
		{
		}

		public void wideScreenMode()
		{
		}

		public void off()
		{
		}
	}
	class TheaterLights
	{
		public void dim(int v)
		{
		}

		public void on()
		{
		}
	}
	class Screen
	{
		public void down()
		{
		}

		public void up()
		{
		}
	}
	class PopcornPopper
	{
		public void on()
		{
		}

		public void pop()
		{
		}

		public void off()
		{
		}
	}



	class HomeTheaterFacad
	{
		Amplifier amp;
		Tuner tuner;
		DvdPlayer dvd;
		CdPlayer cd;
		Projector projector;
		TheaterLights lights;
		Screen screen;
		PopcornPopper popper;

		public HomeTheaterFacad(Amplifier amp,
								Tuner tuner,
								DvdPlayer dvd,
								CdPlayer cd,
								Projector projector,
								TheaterLights lights,
								Screen screen,
								PopcornPopper popper)
		{
			this.amp = amp;
			this.tuner = tuner;
			this.dvd = dvd;
			this.cd = cd;
			this.projector = projector;
			this.lights = lights;
			this.screen = screen;
			this.popper = popper;
		}

		public void watchMovie(string movie)
		{
			Console.WriteLine("Get ready to watch a movie...");
			popper.on();
			popper.pop();
			lights.dim(10);
			screen.down();
			projector.on();
			projector.wideScreenMode();
			amp.on();
			amp.setDvd(dvd);
			amp.setSurroundSound();
			amp.setVolume(5);
			dvd.on();
			dvd.play(movie);

		}

		public void endMovie()
		{
			Console.WriteLine("Shutting movie theater down...");
			popper.off();
			lights.on();
			screen.up();
			projector.off();
			amp.off();
			dvd.stop();
			dvd.eject();
			dvd.off();
		}
	}
}
