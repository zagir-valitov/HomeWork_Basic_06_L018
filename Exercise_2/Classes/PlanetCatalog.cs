namespace Exercise_2.Classes
{
    internal class PlanetCatalog
    {
        static public readonly Planet planet1 = new()
        {
            Name = "Venus",
            SequenceNumber = 1,
            LengthEquator = 15329,
            PreviousPlanet = null
        };

        static public readonly Planet planet2 = new()
        {
            Name = "Earth",
            SequenceNumber = 3,
            LengthEquator = 40075,
            PreviousPlanet = planet1
        };

        static public readonly Planet planet3 = new()
        {
            Name = "Mars",
            SequenceNumber = 4,
            LengthEquator = 21344,
            PreviousPlanet = planet2
        }; 

        static public readonly List<Planet> Planets = [planet1, planet2, planet3];
        
        private int _counterCall = 0;

        public (int? sequenceNumber, int? lengthEquator, string? error) GetPlanetData(string namePlanet)
        {
            _counterCall++;
            string? message = null;
            if (_counterCall > 2)
            {
                _counterCall = 0;
                message = $"Warning: Request {namePlanet} data - You are asking too often!!!\n";
            }
            
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
