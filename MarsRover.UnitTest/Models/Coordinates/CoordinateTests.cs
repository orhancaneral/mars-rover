using AutoBogus;
using MarsRover.Models.Coordinates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTest.Models.Coordinates
{
    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void Coordinate()
        {
            // Arrange
            var query = AutoFaker.Generate<Coordinate>();

            // Assert
            Assert.IsInstanceOfType(query.X, typeof(int));
            Assert.IsInstanceOfType(query.Y, typeof(int));
            Assert.IsInstanceOfType(query.Z, typeof(int));
        }
    }
}
