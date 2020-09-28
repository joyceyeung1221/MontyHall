using System;
using System.Collections.Generic;
using Xunit;
namespace MontyHall.Test
{
    public class ContestantTest
    {
        public ContestantTest()
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
            var contestant = new Contestant();
            contestant.ChooseDoor(doors);
            Assert.IsType<Door>(contestant.ChosenDoor);
        }

        [Fact]
        public void ShouldHaveTheSameDoor_WhenPlayerChooseNotToSwitch()
        {
            var contestant = new Contestant();
            contestant.ChooseDoor(doors);
            var firstDoor = contestant.ChosenDoor;
            contestant.DecideNextMove(doors);
            var secondDoor = contestant.ChosenDoor;

            Assert.Same(firstDoor, secondDoor);


        }

        [Fact]
        public void ShouldHaveDifferentDoor_WhenPlayerChooseToSwitch()
        {
            var contestant = new Contestant(switching: true);
            contestant.ChooseDoor(doors);
            var firstDoor = contestant.ChosenDoor;
            contestant.DecideNextMove(doors);
            var secondDoor = contestant.ChosenDoor;

            Assert.False(firstDoor == secondDoor);


        }
    }
}
