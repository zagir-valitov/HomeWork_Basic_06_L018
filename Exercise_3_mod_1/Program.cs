using Exercise_3_mod_1.Classes;

Console.WriteLine(" ---- Home work 6. Exercise 3 mod_1 ----\n");

var counter = 0;
void GetPlanetInfo(string namePlanet)
{
    (int? sequenceNumber, int? lengthEquator, string? error) = PlanetCatalog.GetPlanetData(namePlanet, name =>
    {
        counter++;
        if (counter > 2)
        {
            counter = 0;
            return $"Warning: Request {name} data - You are asking too often!!!";
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

