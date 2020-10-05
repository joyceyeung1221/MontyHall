using System;
namespace MontyHall
{
    public class Randomiser : IRandom
    {
        public Randomiser()
        {
        }

        public int GenerateRandomNumber(int maxValue)
        {
            var random = new Random();
            return random.Next(maxValue);
        }
    }
}
