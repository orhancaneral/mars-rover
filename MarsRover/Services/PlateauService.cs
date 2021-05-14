using MarsRover.Models.Plateaus;
using System;

namespace MarsRover.Services
{
    public class PlateauService : IPlateauService
    {
        private readonly IPlateau _plateau;
        public IPlateau Plateau { get { return _plateau; } }
        public PlateauService()
        {
            var plateauCommand = Console.ReadLine().Split(" ");
            var plateau = new Plateau(int.Parse(plateauCommand[0]), 0, int.Parse(plateauCommand[1]));
            _plateau = plateau;
        }
    }
    public interface IPlateauService
    {
        public IPlateau Plateau { get; }
    }
}
