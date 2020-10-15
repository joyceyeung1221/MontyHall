using System;
using Moq;
using Xunit;

namespace MontyHall.Test
{
    public class SimulationTest
    {

        Mock<IGame> mockGame = new Mock<IGame>();

        [Theory]
        [InlineData(5)]
        [InlineData(3)]
        public void ShouldCallGameRunMethodCorrectNumberOfTime(int numOfGames)
        {
            var simulator = new Simulator(mockGame.Object, numOfGames);

            simulator.Run();
            mockGame.Verify(x => x.Run(), Times.Exactly(numOfGames));
        }

        [Fact]
        public void ShouldRecordCorrectNumberOfWinningGame()
        {
            mockGame.SetupSequence(x => x.Run())
                .Returns(true)
                .Returns(true)
                .Returns(true)
                .Returns(false)
                .Returns(false)
                .Returns(true);

            var simulator = new Simulator(mockGame.Object, 6);

            var result = simulator.Run();

            Assert.Equal(4, result);

        }
    }
}
