using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Game : IGame
    {
        private Player _player;
        private Host _monty;
        private int _numberOfDoors;
        public List<Door> AvailableDoors { get; private set;}
        private IRandom _randomiser;


        public Game(IRandom randomiser, int num, Player player)
        {
            _randomiser = randomiser;
            _numberOfDoors = num;
            _player = player;
            _monty = new Host();
        }


        private List<Door> DoorSetup( int doorQuantity)
        {
            var doors = CreateDoors(doorQuantity);
            AssignDoorAPrize(doors);
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

        private List<Door> AssignDoorAPrize(List<Door> doors)
        {

            var door = doors[_randomiser.GenerateRandomNumber(doors.Count)];
            door.HasPrize = true;
            return doors;

        }

        private bool DidPlayerWin()
        {
            return _player.ChosenDoor.HasPrize;
        }

        public bool Run()
        {
            AvailableDoors = DoorSetup(_numberOfDoors);
            var door = _player.ChooseDoor(AvailableDoors, _randomiser);
            AvailableDoors.Remove(door);
            var hostDoor = _monty.ChooseDoor(AvailableDoors);
            AvailableDoors.Remove(hostDoor);
            _player.DecideNextMove(AvailableDoors);
            return DidPlayerWin();
        }


    }
}