using System;
using System.Collections.Generic;
using Xunit;
namespace MontyHall.Test
{
    public class HostTest
    {
           List<Door> doors = new List<Door>
        {
            new Door(),
            new Door(),
            new Door()

        };

        [Fact]
        public void ShouldChooseADoorThatDoesNotHaveAPrize()
        {
            var host = new Host();
            var door = host.ChooseDoor(doors);

            
            Assert.False(door.HasPrize);
        }
    }
}