using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Player
    {
        public PlayerStrategy Strategy { get; private set; }
        
        public Door ChosenDoor { get; set; }
        public Player( PlayerStrategy strat)
        {
            Strategy = strat;
        }

        public Player()
        {
            Strategy = PlayerStrategy.Non_Switching;
        }

        public Door ChooseDoor(List<Door> doors, IRandom randomiser)
        {
            var randomNumber = randomiser.GenerateRandomNumber(doors.Count);
            ChosenDoor = doors[randomNumber];
            return ChosenDoor;
        }

        public void DecideNextMove(List<Door> doors)
        {
            if(Strategy == PlayerStrategy.Switching)
            {
                ChosenDoor = doors.Last();
            }
            
        }
    }
}