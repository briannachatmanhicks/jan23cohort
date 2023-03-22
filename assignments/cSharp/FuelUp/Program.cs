// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Create a vehicle class with the following features in a Vehicle.cs file:

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
// Once your vehicle class has been created, head back to Program.cs and complete the following tasks:

// Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
Vehicle Velma = new Vehicle ("Velma", "Cream");
Vehicle SilverBullet = new Vehicle ("Silver Bullet", 4, "Silver", true);
Vehicle DadVan = new Vehicle ("Dad Van", 10, "White", false);
Vehicle Mandy = new Vehicle ("Mandy", 2, "red", true);
// Put all the vehicles you created into a List
List<Vehicle> Vehicles = new List<Vehicle> ();
Vehicles.Add(Velma);
Vehicles.Add(SilverBullet);
Vehicles.Add(DadVan);
Vehicles.Add(Mandy);
// Loop through the List and have each vehicle run its ShowInfo() method
foreach (var vehicle in Vehicles) {
    vehicle.ShowInfo();
    Console.WriteLine("-----------------------------");
}

// Make one of the vehicles Travel 100 miles
Mandy.Travel(100);
// Print the information of the vehicle to verify the distance traveled went up
Mandy.ShowInfo();
// Bonuses:
// Test this: manually set the distance traveled field to 350 and print the information. If your field was public, this will work. Why is this not the best practice to allow our users to change the distance traveled without going through the Travel() method?
// Mandy.DistanceTrav = 350;
// Once you know the answer, make the distance traveled field private. How does this affect the code in Program.cs? Why is this better for us? Write comments in your code explaining your reasoning.