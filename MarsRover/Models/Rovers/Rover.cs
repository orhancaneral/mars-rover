using MarsRover.Enums;
using MarsRover.Models.Coordinates;
using MarsRover.Models.Plateaus;

namespace MarsRover.Models.Rovers
{
    public class Rover : IRover
    {
        private ICoordinate _coordinate;
        private Direction _direction;
        private IPlateau _plateau;

        public ICoordinate Coordinate { get { return _coordinate; } }
        public Direction Direction { get { return _direction; } }
        public IPlateau Plateau { get { return _plateau; } }

        public Rover(ICoordinate coordinate, Direction direction, IPlateau plateau)
        {
            _coordinate = coordinate;
            _direction = direction;
            _plateau = plateau;
        }

        public void Move(Movement command)
        {
            switch (command)
            {
                case Movement.L:
                    TurnLeft();
                    break;
                case Movement.R:
                    TurnRight();
                    break;
                case Movement.M:
                    Forward();
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.W;
                    break;
                case Direction.S:
                    _direction = Direction.E;
                    break;
                case Direction.W:
                    _direction = Direction.S;
                    break;
                case Direction.E:
                    _direction = Direction.N;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (_direction)
            {
                case Direction.N:
                    _direction = Direction.E;
                    break;
                case Direction.S:
                    _direction = Direction.W;
                    break;
                case Direction.W:
                    _direction = Direction.N;
                    break;
                case Direction.E:
                    _direction = Direction.S;
                    break;
                default:
                    break;
            }
        }
        public void Forward()
        {
            switch (_direction)
            {
                case Direction.N:
                    if (_coordinate.Y + 1 <= _plateau.Height)
                        _coordinate.Y += 1;
                    break;
                case Direction.S:
                    if (_coordinate.Y - 1 >= 0)
                        _coordinate.Y -= 1;
                    break;
                case Direction.W:
                    if (_coordinate.X - 1 >= 0)
                        _coordinate.X -= 1;
                    break;
                case Direction.E:
                    if (_coordinate.X + 1 <= _plateau.Width)
                        _coordinate.X += 1;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $"{_coordinate.X} {_coordinate.Y} {_direction}";
        }
    }
}
