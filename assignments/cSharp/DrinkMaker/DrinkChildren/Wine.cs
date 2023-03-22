// Wine has a region it came from.
// Wine has a year it was bottled.

class Wine : Drink
{
    public string Region;
    public int Year;
    public Wine(string name, string color, double temp, int calories, string region, int year) : base(name, color, temp, true, calories) 
    {
        Region = region;
        Year = year;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year: {Year}");
    }
}