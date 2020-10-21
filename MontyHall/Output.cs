using System;
namespace MontyHall
{
    public class Output : IOutput
    {
        public Output()
        {
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
