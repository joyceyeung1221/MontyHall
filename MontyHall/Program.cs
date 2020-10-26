using System;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new Output();
            var presenter = new Presenter(output);
            var montyHall = new MontyHallStatistics(presenter);
            montyHall.Run();
        }
    }
}
