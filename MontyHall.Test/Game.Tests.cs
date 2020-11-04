using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MontyHall.Test
{
    public class GameTests
    {
        int numberOfDoors = 3;
        Player player = new Player();

     

        [Fact]
        public void ShouldReturnTrueWhenPlayerHasDoorWithPrize()
        {
            var door = new Door();
            var mockRandomiser = new Mock<IRandom>(); 
            mockRandomiser.Setup(x => x.GenerateRandomNumber(It.IsAny<int>())).Returns(0);
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);

            Assert.True(game.Run());

        }

        [Fact]
        public void ShouldReturnFalseWhenPlayerHasDoorWithNoPrize()
        {
            var door = new Door();
            
            var mockRandomiser = new Mock<IRandom>(); 
            mockRandomiser.SetupSequence(x => x.GenerateRandomNumber(It.IsAny<int>()))
            .Returns(2)
            .Returns(0);
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);
            
            Assert.False(game.Run());

        }

        [Fact]
        public void GameShouldHaveOneDoorAtEndOfGame()
        {
            var mockRandomiser = new Mock<IRandom>(); 
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);
            game.Run();

            Assert.Equal(1, game.AvailableDoors.GetListOfDoors().Count);
        }

    }
}