using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (temperature > 80)
            {
                Console.WriteLine("Forecast: It's going to be hot today! Put on enough sunscreen.");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Forecast: It's going to be cold today! Put on your thickest coat.");
            }
            else
            {
                Console.WriteLine("Forecast: The weather is moderate today. Just like your personality.");
            }
        }
    }
}
