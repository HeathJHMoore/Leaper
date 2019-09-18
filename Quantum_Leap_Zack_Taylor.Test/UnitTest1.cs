using Quantum_Leap_Zack_Taylor.LeapComponents;
using System;
using Xunit;

namespace Quantum_Leap_Zack_Taylor.Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsPutRightMethodShouldChangeTheEventToTrue()
        {
            //Arrange
            var newEvent = new Event();

            //Act
            newEvent.PutEventRight();


            //Assert
            Assert.True(newEvent.IsPutRight);
        }
    }
}
