﻿   
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class VehicleTurnTests
    {
        private int _xPoint, _yPoint;
        private Vehicle _vehicle;

        [SetUp]
        public void SetUp()
        {
            _xPoint = 123;
            _yPoint = 567;
        }

        [TearDown]
        public void TearDown()
        {
            _xPoint = 0;
            _yPoint = 0;
            _vehicle = null;
        }

        [Test]
        public void VehicleTurnLeft__IfIsNorthOriented_ThenTurnsLeft()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new NorthDirection());

            //Act
            _vehicle.TurnLeft();
            
            //Assert
            Assert.IsInstanceOf(typeof(WestDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnRight__IfIsNorthOriented_ThenTurnsRight()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new NorthDirection());

            //Act
            _vehicle.TurnRight();

            //Assert
            Assert.IsInstanceOf(typeof(EastDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnLeft__IfIsSouthOriented_ThenTurnsRight()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new SouthDirection());

            //Act
            _vehicle.TurnLeft();

            //Assert
            Assert.IsInstanceOf(typeof(EastDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnRight__IfIsSouthOriented_ThenTurnsLeft()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new SouthDirection());

            //Act
            _vehicle.TurnRight();

            //Assert
            Assert.IsInstanceOf(typeof(WestDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnLeft__IfIsEastOriented_ThenTurnsUp()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new EastDirection());

            //Act
            _vehicle.TurnLeft();

            //Assert
            Assert.IsInstanceOf(typeof(NorthDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnRight__IfIsEastOriented_ThenTurnsDownLeft()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new EastDirection());

            //Act
            _vehicle.TurnRight();

            //Assert
            Assert.IsInstanceOf(typeof(SouthDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnLeft__IfIsWestOriented_ThenTurnsDown()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new WestDirection());

            //Act
            _vehicle.TurnLeft();

            //Assert
            Assert.IsInstanceOf(typeof(SouthDirection), _vehicle.Direction);

        }

        [Test]
        public void VehicleTurnRight__IfIsWestOriented_ThenTurnsDownUp()
        {
            //Arrange
            _vehicle = new Vehicle(_xPoint, _yPoint, new WestDirection());

            //Act
            _vehicle.TurnRight();

            //Assert
            Assert.IsInstanceOf(typeof(NorthDirection), _vehicle.Direction);

        }
    }
}