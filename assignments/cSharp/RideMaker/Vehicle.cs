// Fields
    // A name (i.e. Honda Accord, Mountain Bike, Rollerblades)
    // The number of passengers the vehicle carries
    // The color of the vehicle
    // Whether or not the vehicle has an engine
// How many miles the vehicle has already traveled - start this at 0 by default
// Constructors
    // A constructor that allows a user to fill in all fields (except distance traveled)
    // A constructor that only allows a user to fill in name and color and provides default values for all other fields (you can assume it will become some sort of car)
// Methods
    // A method called ShowInfo() prints out all the information about the vehicle
    // A method called Travel() accepts input for distance, adds that distance to the total distance traveled, and prints out a message saying how far the vehicle has gone

class Vehicle {
    public string CarName;
    public int NumPassenger;
    public string Color;
    public bool Engine;
    private int DistanceTrav;

    public Vehicle (string theCarName, int theNumPassenger, string theColor, bool isEngine) {
        CarName = theCarName;
        NumPassenger = theNumPassenger;
        Color = theColor;
        Engine = isEngine;
        DistanceTrav = 0;
    }

    public Vehicle (string theCarName, string theColor) {
        CarName = theCarName;
        Color = theColor;
        NumPassenger = 5;
        Engine = true;
        DistanceTrav = 0;
    }

    public void ShowInfo() {
        Console.WriteLine($"Name: {CarName}");
        Console.WriteLine($"Max Passengers: {NumPassenger}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Distance Traveled: {DistanceTrav}");
    }

    public int Travel(int theNewDistance) {
        DistanceTrav = DistanceTrav + theNewDistance;
        Console.WriteLine($"{CarName} has traveled {theNewDistance}, the new total distance is {DistanceTrav}");
        return DistanceTrav;
    }

}