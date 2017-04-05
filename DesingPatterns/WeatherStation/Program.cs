using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();

			CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

			WeatherInfo info = new WeatherInfo();
			info.temperature = 80;
			info.humidity = 65;
			info.pressure = 29.2f;
			weatherData.setMeasurements(info);
			info.temperature = 70;
			info.humidity = 55;
			info.pressure = 30.2f;
			weatherData.setMeasurements(info);
			info.temperature = 83;
			info.humidity = 62;
			info.pressure = 21.2f;
			weatherData.setMeasurements(info);

			weatherData.EndTransmission();
		}
	}
}
