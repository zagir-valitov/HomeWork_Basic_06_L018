using Exercise_3_Advanced.Classes;

Console.WriteLine(" ---- Home work 6. Exercise 3 Advanced ----\n");

void GetPlanetInfo(string namePlanet)
{
    (int? sequenceNumber, int? lengthEquator, string? error) = PlanetCatalog.GetPlanetData(namePlanet, name =>
    {
        if (name == "Limonia")
        {
            return $"Warning: Request {name} data - This is a forbidden planet!!!\n";
        }
        return null;
    });
    if (lengthEquator is not null)
    {
        Console.WriteLine(
            $"Planet name: {namePlanet}\n" +
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
GetPlanetInfo("Unknown");
