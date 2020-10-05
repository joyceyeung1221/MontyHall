using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MontyHall.Test
{
    public class GameTests
    {

        [Fact]
        public void ShouldRepresentDoorsAsAList()
        {
            var rand = new Randomiser();
            var game = new Game(rand, 3);
            Assert.IsType<List<Door>>(game.AvailableDoors);
        }

        [Fact]
        public void ShouldSetPrizeForOneDoor()
        {
            // TODO: Continue off here

            var mockRandomiser = new Mock<IRandom>(); 
            mockRandomiser.Setup(x => x.GenerateRandomNumber(3)).Returns(0);
            var game = new Game(mockRandomiser.Object, 3);
            Assert.True(game.AvailableDoors[0].HasPrize);
        }
    }
}