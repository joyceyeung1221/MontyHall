using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Game
    {
        private Player _player;
        private Host _monty;
        public List<Door> AvailableDoors { get; private set;}


        public Game(IRandom randomiser, int num, Player player)
        {
            AvailableDoors = DoorSetup(randomiser, num);
            _player = player;
            _monty = new Host();
        }


        private List<Door> DoorSetup(IRandom random, int doorQuantity)
        {
            var doors = CreateDoors(doorQuantity);
            AssignDoorAPrize(random, doors);
            return doors;
        }

        private List<Door> CreateDoors(int doorQuantity)
        {
            List<Door> doors = new List<Door>();
            for (int i = 0; i < doorQuantity; i++)
            {
                doors.Add(new Door());
            }
            return doors;
        }

        private List<Door> AssignDoorAPrize(IRandom random, List<Door> doors)
        {

            var door = doors[random.GenerateRandomNumber(doors.Count)];
            door.HasPrize = true;
            return doors;

        }

        public bool DidPlayerWin()
        {
            return _player.ChosenDoor.HasPrize;
        }

        public void Run()
        {
              //game runs

                //playerChooses a door
                var door = _player.ChooseDoor(AvailableDoors);
                //game removes door from list
                AvailableDoors.Remove(door);
                //monty Chooses a losing door
                var hostDoor = _monty.ChooseDoor(AvailableDoors);
                //game removes door from list
                AvailableDoors.Remove(hostDoor);
                //player chooses door - either the same door or swapping door
                _player.DecideNextMove(AvailableDoors); //TODO: change DecideNextMove to bool
                //compare if the Door player has, has prize or not
                //Did player win
        }


    }
}