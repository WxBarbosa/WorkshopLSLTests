using System;
using System.Collections.Generic;
using System.Text;
using WorkshopLSLTests.Domain.Entities;
using WorkshopLSLTests.Domain.Interfaces;
using Xunit;

namespace WorkshopLSLTests.UnitTest.Scenarios.CarScenarios
{
    public class CarStopDrivingCarTest
    {

        [Fact]
        public void ReturnsException_GivenCarTurnOff()
        {
            //Arrange
            ICar car = new Car();
            car.TurnOn();
            car.TurnOff();
            //Act
            Assert.Throws<InvalidOperationException>(
                //Assert
                () => car.StopDrivingCar()    
            );
        }

        [Fact]
        public void ReturnsIsDrivingCarFalse_GivenStopDrivingCar()
        {
            //Arrange
            ICar car = new Car();
            car.TurnOn();
            //Act
            car.Driving();
            car.StopDrivingCar();
            //Assert
            var expected = false;
            var actual = car.IsDrivingCar();

            Assert.Equal(expected, actual);
        }
    }
}
