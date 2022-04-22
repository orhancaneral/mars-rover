using AutoBogus;
using MarsRover.Enums;
using MarsRover.Models.Coordinates;
using MarsRover.Models.Plateaus;
using MarsRover.Models.Rovers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MarsRover.UnitTest.Models.Rovers
{
    [TestClass]
    public class RoverTests
    {
        private readonly MockRepository _mockRepository;
        private readonly Mock<ICoordinate> _mockCoordinate;
        private readonly Mock<IPlateau> _mockPlateau;
        
        public RoverTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockCoordinate = _mockRepository.Create<ICoordinate>();
            _mockPlateau = _mockRepository.Create<IPlateau>();
        }

        private Rover CreateRover()
        {
            _mockCoordinate.Setup(oe => oe.X).Returns(1);
            _mockCoordinate.Setup(oe => oe.Y).Returns(2);
            _mockCoordinate.Setup(oe => oe.Z).Returns(0);

            _mockPlateau.Setup(oe => oe.Width).Returns(5);
            _mockPlateau.Setup(oe => oe.Height).Returns(5);
            _mockPlateau.Setup(oe => oe.Depth).Returns(0);

            return new Rover(
                _mockCoordinate.Object,
                 Direction.N,
                _mockPlateau.Object);
        }

        [TestMethod]
        public void Move_WhenAtBorder_NotMove()
        {
            // Arrange
            var rover = CreateRover();

            _mockCoordinate.Setup(oe => oe.X).Returns(0);
            _mockCoordinate.Setup(oe => oe.Y).Returns(1);

            // Act
            rover.Move(Movement.L);
            rover.Move(Movement.M);

            // Assert
            Assert.IsTrue(rover.Coordinate.X == 0);
            Assert.IsTrue(rover.Coordinate.Y == 1);
            Assert.IsTrue(rover.Direction == Direction.W);
        }
    }
}
