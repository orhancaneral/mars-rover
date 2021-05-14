using MarsRover.Enums;
using MarsRover.Models.Coordinates;
using System;

namespace MarsRover.Services
{
    public class CoordinateService : ICoordinateService
    {
        private readonly ICoordinate _coordinate;
        public ICoordinate Coordinate { get { return _coordinate; } }

        private readonly Direction _direction;
        public Direction Direction { get { return _direction; } }
        public CoordinateService()
        {
            var coordinateCommand = Console.ReadLine().Split(" ");
            var coordinate = new Coordinate(int.Parse(coordinateCommand[0]), int.Parse(coordinateCommand[1]), 0);
            _coordinate = coordinate;
            _direction = Enum.Parse<Direction>(coordinateCommand[2].ToUpper());
        }
    }
    public interface ICoordinateService
    {
        public ICoordinate Coordinate { get; }
        public Direction Direction { get; }
    }
}
