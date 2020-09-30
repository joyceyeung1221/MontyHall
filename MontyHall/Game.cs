using System.Collections.Generic;

namespace MontyHall
{
    public class Game
    {
        
        public Game()
        {
    
        }

        public List<Door> AvailableDoors { get; private set;} = new List<Door>();
        public void Setup(int doorQuantity)
        {
            for(int i = 0; i < doorQuantity; i++)
            {
                AvailableDoors.Add(new Door());
            }
        }

        
    }
}