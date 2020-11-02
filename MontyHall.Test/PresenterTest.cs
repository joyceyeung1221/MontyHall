using System;
using Xunit;
using Moq;
namespace MontyHall.Test
{
    public class PresenterTest
    {
        [Fact]
        public void ShouldPrintOutStatisticResultString()
        {
            var mockOutput = new Mock<IOutput>();
            var presenter = new Presenter(mockOutput.Object);
            var resultSwitching = new Result(PlayerStrategy.Switching, (double)0.66);
            var resultNonSwitching = new Result(PlayerStrategy.Non_Switching, (double)0.34);
            presenter.DisplayResult(resultSwitching, resultNonSwitching);

            mockOutput.Verify(x => x.Write("For strategy: Switching, the winning percentage is 66%.\nFor strategy: Non_Switching, the winning percentage is 34%."), Times.Exactly(1));
        }
    }
}
