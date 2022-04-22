using AutoBogus;
using MarsRover.Models.Plateaus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTest.Models.Plateaus
{
    [TestClass]
    public class PlateauTests
    {
        [TestMethod]
        public void Plateau()
        {
            // Arrange
            var query = AutoFaker.Generate<Plateau>();

            // Assert
            Assert.IsInstanceOfType(query.Depth, typeof(int));
            Assert.IsInstanceOfType(query.Height, typeof(int));
            Assert.IsInstanceOfType(query.Width, typeof(int));
        }
    }
}
