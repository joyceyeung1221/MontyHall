using System;
using System.Collections.Generic;

namespace MontyHall
{
    public class Game
    {
        public List<Door> AvailableDoors { get; private set;}
        public Game(IRandom randomiser, int num)
        {
            AvailableDoors = DoorSetup(randomiser, num);
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

    }
}