namespace Exercise_2.Classes
{
    internal class Planet
    {
        public string? Name { get; set; }
        public int SequenceNumber { get; set; }
        public int LengthEquator { get; set; }
        public Planet? PreviousPlanet { get; set; }
    }
}