using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Game : IGame
    {
        private Player _player;
        private Host _monty;
        private int _numberOfDoors;
        public DoorsCollection AvailableDoors { get; private set;} 
        private IRandom _randomiser;


        public Game(IRandom randomiser, int num, Player player)
        {
            _randomiser = randomiser;
            _numberOfDoors = num;
            _player = player;
            _monty = new Host();
        }


        private bool DidPlayerWin()
        {
            return _player.ChosenDoor.HasPrize;
        }

        public bool Run()
        {
            AvailableDoors = new DoorsCollection(_numberOfDoors);
            AvailableDoors.AssignDoorAPrize(_randomiser);
            var door = _player.ChooseDoor(AvailableDoors.GetListOfDoors(), _randomiser);
            AvailableDoors.RemoveDoor(door);
            var hostDoor = _monty.ChooseDoor(AvailableDoors.GetListOfDoors());
            AvailableDoors.RemoveDoor(hostDoor);
            _player.DecideNextMove(AvailableDoors.GetListOfDoors());
            return DidPlayerWin();
        }


    }
}