Console.WriteLine(" ---- Home work 6. Exercise 1 ----\n");

var planet1 = new
{
    Name = "Venus",
    SequenceNumber = 2,
    LengthEquator = 38025,
    PreviousPlanet = new 
    {
        Name = "Mercury",
        SequenceNumber = 1,
        LengthEquator = 15329,
        PreviousPlanet = "Sun"
    }
};

var planet2 = new
{
    Name = "Earth",
    SequenceNumber = 3,
    LengthEquator = 40075,
    PreviousPlanet = planet1
};

var planet3 = new
{
    Name = "Mars",
    SequenceNumber = 4,
    LengthEquator = 21344,
    PreviousPlanet = planet2
};

var planet4 = new
{
    Name = "Venus",
    SequenceNumber = 2,
    LengthEquator = 38025,
    PreviousPlanet = new
    {
        Name = "Mercury",
        SequenceNumber = 1,
        LengthEquator = 15329,
        PreviousPlanet = "Sun"
    }
};


Console.WriteLine(
    $"Planet: \t\t{planet1.Name}\n" +
    $"Sequence Number:\t{planet1.SequenceNumber}\n" +
    $"Length Equator:\t\t{planet1.LengthEquator} km\n" +
    $"Previous Planet:\t{planet1.PreviousPlanet.Name}\n" +
    $"Equivalence with Venus: {planet1.Equals(planet1)}\n" +
    $"--------------------------------------\n");

Console.WriteLine(
    $"Planet: \t\t{planet2.Name}\n" +
    $"Sequence Number:\t{planet2.SequenceNumber}\n" +
    $"Length Equator:\t\t{planet2.LengthEquator} km\n" +
    $"Previous Planet:\t{planet2.PreviousPlanet.Name}\n" +
    $"Equivalence with Venus: {planet2.Equals(planet1)}\n" +
    $"--------------------------------------\n");

Console.WriteLine(
    $"Planet: \t\t{planet3.Name}\n" +
    $"Sequence Number:\t{planet3.SequenceNumber}\n" +
    $"Length Equator:\t\t{planet3.LengthEquator} km\n" +
    $"Previous Planet:\t{planet3.PreviousPlanet.Name}\n" +
    $"Equivalence with Venus: {planet3.Equals(planet1)}\n" +
    $"--------------------------------------\n");

Console.WriteLine(
    $"Planet: \t\t{planet4.Name}\n" +
    $"Sequence Number:\t{planet4.SequenceNumber}\n" +
    $"Length Equator:\t\t{planet4.LengthEquator} km\n" +
    $"Previous Planet:\t{planet4.PreviousPlanet.Name}\n" +
    $"Equivalence with Venus: {planet4.Equals(planet1)}\n" +
    $"--------------------------------------\n");