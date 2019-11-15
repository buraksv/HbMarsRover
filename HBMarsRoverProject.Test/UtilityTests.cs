using HBMarsRoverProject.Business.Implementations;
using HBMarsRoverProject.Business.Utilities;
using HBMarsRoverProject.Entity;
using NUnit.Framework;

namespace HBMarsRoverProject.Test
{
    public class UtilityTests
    {
        [SetUp]
        public void Setup()
        {
        }

     
        [Test]
        [TestCase(5,5, "3 3 E", "MMRMMRMRRM", "5 1 E")]
        [TestCase(5,5, "1 2 N", "LMLMLMLMM", "1 3 N")]
        public void Rover_RunTest(int plateauDimensionX,int plateauDimensionY, string location,string directions,string output)
        {
            Plateau plateau = new Plateau();
            plateau.Resize(plateauDimensionX, plateauDimensionY);

            Input input = new Input(location,directions);
              
            Assert.True(input.Run(plateau)== output);
        }
 

 
    }
}