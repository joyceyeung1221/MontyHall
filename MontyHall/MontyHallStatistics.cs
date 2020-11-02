using System.Reflection.PortableExecutable;
namespace MontyHall
{
    public class MontyHallStatistics
    {
        //Run{
            
            //calculator
        //need number of simulations to run
        //new up 2 games
        //new up 2 players - one switching, one non-switching
        //new up 2 simulation - inject a game with a player
        //run simA -> number of winning games (A)
        //run simB -> number of winning games (B)
        //cal -> A%
        //cal ->B%
        // returns A% B%
        //  }

        private Presenter _presenter;
        private Calculator _calculator;
        private Randomiser _randomiser;
        private Player _player1;
        private Player _player2;
        private const int NumberOfRuns = 1000;
        private const int NumberOfDoors = 3;

        public MontyHallStatistics(Presenter presenter, Player player1, Player player2)
        {
            _presenter = presenter;
            _calculator = new Calculator();
            _randomiser = new Randomiser();
            _player1 = player1;
            _player2 = player2;
        }

        public void Run()
        {
            var result1 = CreateResult(_player1);
            var result2 = CreateResult(_player2);
            _presenter.DisplayResult(result1, result2);
        }

        private Result CreateResult(Player player)
        {
            var game = new Game(_randomiser, NumberOfDoors, player);
            var simulator = new Simulator(game, NumberOfRuns);
            var numberOfWins = simulator.Run();
            return _calculator.CalculateResult(player.Strategy, numberOfWins, NumberOfRuns);
        }

    }
}