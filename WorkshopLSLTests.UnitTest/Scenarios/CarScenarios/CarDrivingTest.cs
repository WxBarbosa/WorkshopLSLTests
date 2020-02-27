using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WorkshopLSLTests.Domain.Entities;
using WorkshopLSLTests.Domain.Interfaces;

namespace WorkshopLSLTests.UnitTest.Scenarios.CarScenarios
{
    public class CarDrivingTest
    {
        [Fact]
        public void ReturnsIsDrivingFalse_GivenCarTurnOff()
        {
            //Arrange
            ICar car = new Car();
            car.TurnOn();
            car.TurnOff();
            //Act
            car.Driving();
            //Assert
            var expected = false;
            var actual = car.IsDrivingCar();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsIsDrivingTrue_GivenCarTurnOn()
        {
            //Arrange
            ICar car = new Car();
            car.TurnOn();
            //Act
            car.Driving();
            //Assert
            var expected = true;
            var actual = car.IsDrivingCar();

            Assert.Equal(expected, actual);
        }
    }
}
