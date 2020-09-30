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
            var game = new Game();
            game.Setup(3);
            Assert.IsType<List<Door>>(game.AvailableDoors);
        }

        [Fact]
        public void ShouldSetPrizeForOneDoor()
        {
            // TODO: Continue off here
            var mockRandomiser = new Mock<IRandom>();
            mockRandomiser.Setup(x => x.AssignPrize()).Returns();
            var game = new Game(mockRandomiser);
            
            game.Setup(3);
            Assert.True(game.AvailableDoors[0].HasPrize);
        }
    }
}