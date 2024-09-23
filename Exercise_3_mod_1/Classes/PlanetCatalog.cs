using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_mod_1.Classes
{
    internal class PlanetCatalog
    {
        public static readonly Planet planet1 = new()
        {
            Name = "Venus",
            SequenceNumber = 1,
            LengthEquator = 15329,
            PreviousPlanet = null
        };
        public static readonly Planet planet2 = new()
        {
            Name = "Earth",
            SequenceNumber = 3,
            LengthEquator = 40075,
            PreviousPlanet = planet1
        };
        public static readonly Planet planet3 = new()
        {
            Name = "Mars",
            SequenceNumber = 4,
            LengthEquator = 21344,
            PreviousPlanet = planet2
        };
        public static readonly List<Planet> Planets = [planet1, planet2, planet3];

        public delegate string? PlanetValidator(string? namePlanet);
        public static (int? sequenceNumber, int? lengthEquator, string? error) GetPlanetData(string namePlanet, PlanetValidator validatorDelegate)
        {
            string? message = validatorDelegate(namePlanet);

            foreach (var planet in Planets)
            {
                if (planet.Name == namePlanet)
                {
                    return (sequenceNumber: planet.SequenceNumber, lengthEquator: planet.LengthEquator, error: message);
                }
            }
            return (sequenceNumber: null, lengthEquator: null, error: $"\nWarning: Request {namePlanet} data - Unable to find planet!!!\n{message}");
        }
    }
}
