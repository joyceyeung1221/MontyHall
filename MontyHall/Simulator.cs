using System;
namespace MontyHall
{
    public class Simulator
    {
        private IGame _game;
        private int _numOfSimulations;

        public Simulator(IGame game, int numOfSimulations)
        {
            _game = game;
            _numOfSimulations = numOfSimulations;
        }

        public int Run()
        {
            int counter = 0;
            for (var i = 0; i < _numOfSimulations; i++)
            {
                counter += AddWinningGame();
            }
            return counter;
        }

        private int AddWinningGame()
        {
            return _game.Run() ? 1 : 0;
        }
    }
}
