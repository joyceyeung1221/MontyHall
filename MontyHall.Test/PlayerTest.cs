using System;
using System.Collections.Generic;
using Moq;
using Xunit;
namespace MontyHall.Test
{
    public class PlayerTest
    {
        List<Door> doors = new List<Door>
        {
            new Door(),
            new Door(),
            new Door()

        };

        [Fact]
        public void ShouldHaveADoor_WhenPlayerChooseADoor()
        {
            var player = new Player();
            player.ChooseDoor(doors, new Randomiser());
            Assert.IsType<Door>(player.ChosenDoor);
        }

        [Fact]
        public void ShouldHaveTheSameDoor_WhenPlayerChooseNotToSwitch()
        {
            var player = new Player();
            player.ChooseDoor(doors,new Randomiser());
            var firstDoor = player.ChosenDoor;
            player.DecideNextMove(doors);
            var secondDoor = player.ChosenDoor;

            Assert.Same(firstDoor, secondDoor);
        }

        [Fact]
        public void ShouldHaveDifferentDoor_WhenPlayerChooseToSwitch()
        {
            var player = new Player(PlayerStrategy.Switching);
            var mockRandomiser = new Mock<IRandom>();

            mockRandomiser.Setup(x => x.GenerateRandomNumber(It.IsAny<int>())).Returns(0);
            player.ChooseDoor(doors,mockRandomiser.Object);

            var firstDoor = player.ChosenDoor;
            player.DecideNextMove(doors);
            var secondDoor = player.ChosenDoor;

            Assert.False(firstDoor == secondDoor);

        }
    }
}
