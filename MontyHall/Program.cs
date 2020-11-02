using System;

namespace MontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new Output();
            var presenter = new Presenter(output);
            var player1 = new Player(PlayerStrategy.Non_Switching);
            var player2 = new Player(PlayerStrategy.Switching);
            var montyHall = new MontyHallStatistics(presenter, player1, player2);
            montyHall.Run();
        }
    }
}
