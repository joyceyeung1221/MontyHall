using System;
namespace MontyHall
{
    public class Calculator
    {
        public Result CalculateResult(PlayerStrategy strategy, int numberOfWins, int numberOfRuns)
        {
            System.Console.WriteLine($"Number of wins is {numberOfWins}");
            System.Console.WriteLine($"Number of runs is {numberOfRuns}");
            double percentage = (double)numberOfWins / numberOfRuns;
            System.Console.WriteLine($"% is {percentage:N2}");
            return new Result(strategy, percentage);
        }
    }
}
