using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Host
    {
        public Door chosenDoor;
        public Door ChooseDoor(List<Door> doors)
        {
            foreach(Door d in doors)
            {
                if(!d.HasPrize) 
                {
                    chosenDoor = d;
                }
            }
            return chosenDoor;
        }
    }
}

