using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
	class CurrentConditionsDisplay : IObserver<WeatherInfo>, DisplayElement
	{
		private IDisposable unsubscriber;
		private IObservable<WeatherInfo> observable;
		private WeatherInfo info = new WeatherInfo();

		public CurrentConditionsDisplay(IObservable<WeatherInfo> observable)
		{
			this.observable = observable;
			unsubscriber = observable.Subscribe(this);
		}
		
		public void display()
		{
			Console.WriteLine("Current conditions: " + info.temperature + "F degrees and " + info.humidity + "% humidity");
		}

		public void OnCompleted()
		{
		}
		
		public void OnError(Exception error)
		{
		}
		
		public void OnNext(WeatherInfo value)
		{
			info.temperature = value.temperature;
			info.humidity = value.humidity;
			display();
		}
	}
}
