using System;
namespace MontyHall
{
    public class Result
    {
        public PlayerStrategy Strategy;
        public double WinningPercentage;

        public Result(PlayerStrategy strategy, double winningPercentage)
        {
            Strategy = strategy;
            WinningPercentage = winningPercentage;
        }
    }
}
