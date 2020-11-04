using System.Collections.Generic;
namespace MontyHall
{
    
    public class DoorsCollection
    {
        private List<Door> _doors;

        public DoorsCollection(int doorQuantity)
        {
            _doors = CreateDoors(doorQuantity);
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

        public void AssignDoorAPrize( IRandom randomiser)
        {
            var doorWithPrize = _doors[randomiser.GenerateRandomNumber(_doors.Count)];
            doorWithPrize.HasPrize = true;
            
        }

        public void RemoveDoor(Door door)
        {
            _doors.Remove(door);
        }

        public List<Door> GetListOfDoors()
        {
           return _doors; 
        }
    }
}