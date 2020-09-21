using System;
namespace MontyHall
{
    public class Door
    {
       
        public bool HasPrize { get; private set; }

        public Door()
        {
            HasPrize = false;
        }

        public bool Reveal()
        {
            return this.HasPrize;
        }

        public void AssignPrize()
        {
            this.HasPrize = true;
        }
        
    }
}
