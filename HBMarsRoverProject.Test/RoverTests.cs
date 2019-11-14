using System;
using HBMarsRoverProject.Business.Implementations;
using HBMarsRoverProject.Entity;
using NUnit.Framework;

namespace HBMarsRoverProject.Test
{
    public class RoverTests
    {
       


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(1,2,"N")]
        public void Rover_RelocationTest(int x,int y,string direction)
        { 
            Rover rover = new Rover();
            rover.Relocation(new Coordinate(x, y, direction));

            var outputCoordinate = new Coordinate(x, y, direction);

            Assert.True(rover.CurrentCoordinate.X==outputCoordinate.X && rover.CurrentCoordinate.Y==outputCoordinate.Y && rover.CurrentCoordinate.Direction==outputCoordinate.Direction);

        }

        [Test]
        [TestCase(1, 2, "N")]
        public void Rover_TurnTest(int x, int y, string direction)
        {
            Rover rover = new Rover(x,y,direction);
             

            rover.Turn(EnumRotation.Right);

            Assert.True(rover.CurrentCoordinate.Direction==EnumDirection.E);
        }

        [Test]
        [TestCase(1, 2, "N")]
        public void Rover_MoveTest(int x, int y, string direction)
        {

            Rover rover = new Rover(x, y ,direction);


            rover.Move();


            Assert.True(rover.CurrentCoordinate.Y==3);
        }

        [Test]
        [TestCase(1, 2, "N")]
        public void Rover_CommandTest(int x, int y, string direction)
        {
            Rover rover = new Rover(x, y, direction);


            rover.Command('L');

            Assert.True(rover.CurrentCoordinate.Direction==EnumDirection.W);
        }
        [Test]
        [TestCase(1, 2, "N")]
        public void Rover_ResetTest(int x, int y, string direction)
        {
            Rover rover = new Rover(x, y, direction);


            rover.Reset();
            Assert.True(rover.CurrentCoordinate.X == 0 && rover.CurrentCoordinate.Y == 0 && rover.CurrentCoordinate.Direction == EnumDirection.N);

        }
    }
}