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
        public void ShouldRepresentDoorsAsAList()
        {
            var rand = new Randomiser();
            var game = new Game(rand, 3, player);
            Assert.IsType<List<Door>>(game.AvailableDoors);
        }

        [Fact]
        public void ShouldSetPrizeForOneDoor()
        {
            // TODO: Continue off here

            var mockRandomiser = new Mock<IRandom>(); 
            mockRandomiser.Setup(x => x.GenerateRandomNumber(3)).Returns(0);
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);
            Assert.True(game.AvailableDoors[0].HasPrize);
        }

        [Fact]
        public void ShouldReturnTrueWhenPlayerHasDoorWithPrize()
        {
            var door = new Door();
            
            var mockRandomiser = new Mock<IRandom>(); 
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);

            door.HasPrize = true;
            player.ChosenDoor = door;

            Assert.True(game.DidPlayerWin());

        }

        [Fact]
        public void ShouldReturnFalseWhenPlayerHasDoorWithNoPrize()
        {
            var door = new Door();
            
            var mockRandomiser = new Mock<IRandom>(); 
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);

            door.HasPrize = false;
            player.ChosenDoor = door;

            Assert.False(game.DidPlayerWin());

        }

        [Fact]
        public void GameShouldHaveOneDoorAtEndOfGame()
        {
            var mockRandomiser = new Mock<IRandom>(); 
            var game = new Game(mockRandomiser.Object, numberOfDoors, player);
            game.Run();

            Assert.Equal(1, game.AvailableDoors.Count);
        }



        //test that the game removes the players selected door from list of doors
            //stub in a list of doors
            //run the 'removeDoor method
            //check door list count


            //game runs
                //set up
                //playerChooses a door
                //game removes door from list
                //monty Chooses a losing door
                //game removes door from list
                //player chooses door - either the same door or swapping door
                //compare if the Door player has, has prize or not
                //Did player win
    }
}