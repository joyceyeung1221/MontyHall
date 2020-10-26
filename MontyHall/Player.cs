using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Player
    {
        private PlayerStrategy _switching;

        
        public Door ChosenDoor { get; set; }
        public Player( PlayerStrategy strat)
        {
            _switching = strat;
        }

        public Player()
        {
            _switching = PlayerStrategy.Non_Switching;
        }

        public Door ChooseDoor(List<Door> doors, IRandom randomiser)
        {
            var randomNumber = randomiser.GenerateRandomNumber(doors.Count);
            ChosenDoor = doors[randomNumber];
            return ChosenDoor;
        }

        public void DecideNextMove(List<Door> doors)
        {
            
            if(_switching == PlayerStrategy.Switching)
            {
                ChosenDoor = doors.Last();
            }
            
        }
    }
}