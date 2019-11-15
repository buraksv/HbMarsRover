using HBMarsRoverProject.Business.Implementations;
using NUnit.Framework;

namespace HBMarsRoverProject.Test
{
    public class PlateauTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5,5)]
        public void Plateau_ResizeTest(int x,int y)
        {
            Plateau plateau = new Plateau();

            plateau.Resize(x, y);

            Assert.True(plateau.CurrentDimension.X == y && plateau.CurrentDimension.Y == y);

        }
    }
}