using MarsRover.Enums;
using MarsRover.Models.Vehicles;

namespace MarsRover.Models.Rovers
{
    public interface IRover : IVehicle
    {
        public void TurnLeft();
        public void TurnRight();
        public void Forward();
        public void Move(Movement command);
    }
}
