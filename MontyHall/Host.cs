using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Host
    {
        public Door chosenDoor;
        public void ChooseDoor(List<Door> doors)
        {
            foreach(Door d in doors)
            {
                if(!d.HasPrize) //TODO: Would be nice to have Monty pick a 'random' losing door
                {
                    //pick a door
                    chosenDoor = d;
                    return;
                }
            }
        }
    }
}

