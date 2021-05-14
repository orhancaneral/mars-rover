using MarsRover.Enums;
using MarsRover.Models.Coordinates;
using MarsRover.Models.Plateaus;

namespace MarsRover.Models.Vehicles
{
    public interface IVehicle
    {
        public ICoordinate Coordinate { get; }
        public Direction Direction { get; }
        public IPlateau Plateau { get; }
    }
}
