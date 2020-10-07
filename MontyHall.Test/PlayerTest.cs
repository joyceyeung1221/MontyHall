using System;
using System.Collections.Generic;
using Xunit;
namespace MontyHall.Test
{
    public class PlayerTest
    {
        public PlayerTest()
        {
        }

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
            player.ChooseDoor(doors);
            Assert.IsType<Door>(player.ChosenDoor);
        }

        [Fact]
        public void ShouldHaveTheSameDoor_WhenPlayerChooseNotToSwitch()
        {
            var player = new Player();
            player.ChooseDoor(doors);
            var firstDoor = player.ChosenDoor;
            player.DecideNextMove(doors);
            var secondDoor = player.ChosenDoor;

            Assert.Same(firstDoor, secondDoor);


        }

        [Fact]
        public void ShouldHaveDifferentDoor_WhenPlayerChooseToSwitch()
        {
            var player = new Player(switching: true);
            player.ChooseDoor(doors);
            var firstDoor = player.ChosenDoor;
            player.DecideNextMove(doors);
            var secondDoor = player.ChosenDoor;

            Assert.False(firstDoor == secondDoor);


        }
    }
}
