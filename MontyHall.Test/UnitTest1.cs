using System;
using Xunit;

namespace MontyHall.Test
{
    public class DoorShould
    {
        [Fact]
        public void SetTheValueWhetherThereIsAPrize()
        {
            var door = new Door();
            door.AssignPrize();
            var actual = door.Reveal();

            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFalseForDoorWithNoPrize()
        {
            var door = new Door();
            var actual = door.Reveal();

            var expected = false;
            Assert.Equal(expected, actual);
        }
    }
}
