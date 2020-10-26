using System;
namespace MontyHall
{
    public class Presenter
    {
        private IOutput _output;

        public Presenter(IOutput output)
        {
            _output = output;
        }

        public void DisplayResult(Result strategyOne, Result strategyTwo)
        {
            var text = $"For strategy: {strategyOne.Strategy}, the winning percentage is {strategyOne.WinningPercentage * 100}\n" +
                       $"For strategy: {strategyTwo.Strategy}, the winning percentage is {strategyTwo.WinningPercentage * 100}";

            _output.Write(text);
        }
    }
}
