namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(() =>
                {
                    ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

                    Console.WriteLine(boiler.GetHashCode());
                });

                threads.Add(thread);
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Dit is het einde van al mijn threads :)");
        }
    }
}