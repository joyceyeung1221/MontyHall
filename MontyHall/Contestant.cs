using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Contestant
    {
        private bool _switching;

        
        public Door ChosenDoor { get; set; }
        public Contestant( bool switching = false)
        {
            _switching = switching;
        }

        public void ChooseDoor(List<Door> doors)
        {
            ChosenDoor = doors.First();
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