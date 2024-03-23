using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.S2
{
    public class Stopwatch
    {
        private bool _running;
        private DateTime Time { get; set; } = new DateTime();

        public Stopwatch()
        {
            Run();
        }

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Cannot Start two times in a row");
            }

            Time = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            _running = false;
            TimeSpan duration = DateTime.Now - Time;
            Console.WriteLine($"Duration: {duration.ToString(@"\D\:dd\ \H\:hh\ \M\:mm\ \S\:ss")}");
        }

        public void Run()
        {
            string? input = null;
            while (input != "quit")
            {
                Console.Write(
                    "Please enter 'Start' or 'Stop' to interact with stopwatch, or 'Quit' to exit: "
                );
                input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case "start":
                        try
                        {
                            Start();
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Cannot start twice in a row");
                        }
                        break;
                    case "stop":
                        Stop();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
