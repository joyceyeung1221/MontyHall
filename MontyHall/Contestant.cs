using System;
using System.Collections.Generic;
using System.Linq;

namespace MontyHall
{
    public class Contestant
    {
        public Door ChosenDoor { get; set; }
        public Contestant()
        {
        }

        public void ChooseDoor(List<Door> doors)
        {
            ChosenDoor = doors.First();
        }

        public void DecideNextMove(List<Door> doors)
        {

        }
    }
}