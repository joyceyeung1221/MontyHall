using System;
namespace MontyHall
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public Result CalculateResult(PlayerStrategy strategy, int numberOfWins, int numberOfRuns)
        {
            double percentage = Math.Round((double)numberOfWins / numberOfRuns);

            return new Result(strategy, percentage);
        }
    }
}
