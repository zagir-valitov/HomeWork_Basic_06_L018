using Exercise_2.Classes;
Console.WriteLine(" ---- Home work 6. Exercise 2 ----\n");

var planetCatalog = new PlanetCatalog();

void GetPlanetInfo(string planetName)
{
    (int? sequenceNumber, int? lengthEquator, string? error) = planetCatalog.GetPlanetData(planetName);
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