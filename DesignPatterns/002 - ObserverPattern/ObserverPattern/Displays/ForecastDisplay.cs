using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public override void Display()
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