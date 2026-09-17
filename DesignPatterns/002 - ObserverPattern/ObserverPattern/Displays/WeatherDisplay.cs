using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, DisplayElement
    {
        protected float temperature;
        protected float humidity;
        protected Subject weatherData;
        public WeatherDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public abstract void Update(float temp, float humidity, float pressure);
        public abstract void Display();
    }
}
