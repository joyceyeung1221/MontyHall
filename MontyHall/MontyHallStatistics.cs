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
        private const int NumberOfRuns = 1000;
        private const int NumberOfDoors = 3;

        public MontyHallStatistics(Presenter presenter)
        {
            _presenter = presenter;
        }

        public void Run()
        {
            var calculator = new Calculator();

            var randomiser = new Randomiser();
            var playerSwitchStrat = PlayerStrategy.Non_Switching;
            var playerNonSwitchStrat = PlayerStrategy.Switching;
            var playerNonSwitching = new Player(playerSwitchStrat);
            var playerSwitching = new Player(playerNonSwitchStrat);

            var game1 = new Game(randomiser, NumberOfDoors, playerNonSwitching);
            var game2 = new Game(randomiser, NumberOfDoors, playerSwitching);

            var simulator1 = new Simulator(game1, NumberOfRuns);
            var simulator2 = new Simulator(game2, NumberOfRuns);

            var numberOfWins1 = simulator1.Run();
            var numberOfWins2 = simulator2.Run();

            var result1 = calculator.CalculateResult(playerSwitchStrat, numberOfWins1, NumberOfRuns);
            var result2 = calculator.CalculateResult(playerNonSwitchStrat, numberOfWins2, NumberOfRuns);

            _presenter.DisplayResult(result1, result2);
        }


    }
}