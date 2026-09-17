using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            sumTemperature += temp;

            if (countUpdated == 0)
            {
                maxTemp = temp;
                minTemp = temp;
            }
            else
            {
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }

                if (temp < minTemp)
                {
                    minTemp = temp;
                }
            }

            countUpdated++;
            Display();
        }

        public override void Display()
        {
            float average = sumTemperature / countUpdated;

            Console.WriteLine($"Average temperature: {average}°C");
            Console.WriteLine($"Maximum temperature: {maxTemp}°C");
            Console.WriteLine($"Minimum temperature: {minTemp}°C");
        }
    }
}