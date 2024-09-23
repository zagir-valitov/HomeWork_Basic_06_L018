using Exercise_3.Classes;

Console.WriteLine(" ---- Home work 6. Exercise 3 ----\n");

void GetPlanetInfo(string planetName)
{
    (int? sequenceNumber, int? lengthEquator, string? error) = PlanetCatalog.GetPlanetData(planetName, PlanetCatalog.CounterCall);
    if (lengthEquator is not null)
    {
        Console.WriteLine(
            $"Planet name: {planetName}\n" +
            $"Sequence Number: {sequenceNumber}\n" +
            $"Length Equator: {lengthEquator}");
    }
    if (error is not null)
    {
        Console.WriteLine(error);
    }
}

GetPlanetInfo("Earth");
GetPlanetInfo("Limonia");
GetPlanetInfo("Mars");