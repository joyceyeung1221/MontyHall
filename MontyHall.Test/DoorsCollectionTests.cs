using Xunit;
using Moq;


namespace MontyHall.Test
{
    
    public class DoorsCollectionTests
    {
        int numberOfDoors = 3;

           [Fact]
        public void ShouldSetPrizeForOneDoor()
        {
            var mockRandomiser = new Mock<IRandom>(); 
            mockRandomiser.Setup(x => x.GenerateRandomNumber(3)).Returns(2);

            var doors = new DoorsCollection(numberOfDoors);
            doors.AssignDoorAPrize(mockRandomiser.Object);
            
            Assert.True(doors.GetListOfDoors()[2].HasPrize);
            Assert.False(doors.GetListOfDoors()[1].HasPrize);
            
            // TODO: Go through the GitHub questions.
        }
    }
}