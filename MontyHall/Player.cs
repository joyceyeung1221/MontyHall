using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Player
    {
        private bool _switching;

        
        public Door ChosenDoor { get; set; }
        public Player( bool switching = false)
        {
            _switching = switching;
        }

        public Door ChooseDoor(List<Door> doors, IRandom randomiser)
        {
            var randomNumber = randomiser.GenerateRandomNumber(doors.Count);
            ChosenDoor = doors[randomNumber];
            return ChosenDoor;
        }

        public void DecideNextMove(List<Door> doors)
        {
            
            if(_switching)
            {
                ChosenDoor = doors.Last();
            }
            
        }
    }
}