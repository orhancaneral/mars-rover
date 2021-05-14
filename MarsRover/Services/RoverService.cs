using MarsRover.Enums;
using MarsRover.Models.Rovers;
using System;

namespace MarsRover.Services
{
    public class RoverService : IRoverService
    {
        private readonly IPlateauService _plateauService;
        private readonly ICoordinateService _coordinateService;

        public Rover CurrentRover { get; set; }
        public RoverService(IPlateauService plateauService, ICoordinateService coordinateService)
        {
            _plateauService = plateauService;
            _coordinateService = coordinateService;

            CurrentRover = new Rover(
                coordinate: _coordinateService.Coordinate,
                direction: _coordinateService.Direction,
                plateau: _plateauService.Plateau);
        }

        public void Start()
        {
            var commands = Console.ReadLine().ToUpper();
            foreach (var item in commands)
            {
                CurrentRover.Move(Enum.Parse<Movement>(item.ToString()));
            }

            Console.WriteLine(CurrentRover.ToString());
        }
    }
    public interface IRoverService
    {
        public void Start();
    }
}
