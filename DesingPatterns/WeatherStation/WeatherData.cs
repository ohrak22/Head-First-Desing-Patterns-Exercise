using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
	class WeatherData : IObservable<WeatherInfo>
	{
		private List<IObserver<WeatherInfo>> observers;

		public WeatherData()
		{
			observers = new List<IObserver<WeatherInfo>>();
		}

		public IDisposable Subscribe(IObserver<WeatherInfo> observer)
		{
			if(!observers.Contains(observer))
				observers.Add(observer);
			return new Unsubscriber(observers, observer);
		}

		private class Unsubscriber : IDisposable
		{
			private List<IObserver<WeatherInfo>> _observers;
			private IObserver<WeatherInfo> _observer;

			public Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
			{
				this._observers = observers;
				this._observer = observer;
			}

			public void Dispose()
			{
				if(_observer != null && _observers.Contains(_observer))
					_observers.Remove(_observer);
			}
		}

		public void setMeasurements(WeatherInfo info)
		{
			foreach(var observer in observers)
			{
				observer.OnNext(info);
			}
		}

		public void EndTransmission()
		{
			foreach(var observer in observers.ToArray())
				if(observers.Contains(observer))
					observer.OnCompleted();

			observers.Clear();
		}
	}
}

public class LocationUnknownException : Exception
{
	internal LocationUnknownException()
	{ }
}