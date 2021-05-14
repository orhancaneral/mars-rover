using MarsRover.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<IPlateauService, PlateauService>()
               .AddTransient<ICoordinateService, CoordinateService>()
               .AddTransient<IRoverService, RoverService>()
               .BuildServiceProvider();

            while (true)
            {
                var roverService = serviceProvider.GetService<IRoverService>();
                roverService.Start();
            }
        }
    }
}
