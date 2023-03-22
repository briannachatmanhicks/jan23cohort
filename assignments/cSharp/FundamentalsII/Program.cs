// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ------------------------------------Three Basic Arrays ------------------------------------
// Create an integer array with the values 0 through 9 inside.
int[] array1;
array1 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 20, 9};


// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] array2;
array2 = new string[] {"Tim","Martin","Nikki","Sara"};


// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] array3 = new bool[10];

for (int i =0; i < 10; i++) {
    if (i % 2 == 0) {
        array3[i] = true;
    }
    else {
        array3[i] = false;
    }
    Console.WriteLine(array3[i]);
} // Console.WriteLine(bool.array3[]); how can i print this whole array?


// ------------------------------------List of Flavors------------------------------------
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCreamFlav = new List<string>() {"chocolate", "vanilla", "red velvet", "cookies n cream", "caramel crunch", "hidden valley"};

// Output the length of the List after you added the flavors.
Console.WriteLine(iceCreamFlav.Count);

// Output the third flavor in the List.
Console.WriteLine(iceCreamFlav[2]);

// Now remove the third flavor using its index location.
iceCreamFlav.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine(iceCreamFlav.Count);

// ------------------------------------User Dictionary------------------------------------
// Create a dictionary that will store string keys and string values.
Dictionary<string,string> NameandFlav = new Dictionary<string,string>();

// Add key/value pairs to the dictionary where:
//      Each key is a name from your names array (this can be done by hand or using logic)
//      Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random rand = new Random();
NameandFlav.Add ("Tim", iceCreamFlav[rand.Next(6)]);
NameandFlav.Add ("Martin", iceCreamFlav[rand.Next(6)]);
NameandFlav.Add ("Nikki", iceCreamFlav[rand.Next(6)]);
NameandFlav.Add ("Sara", iceCreamFlav[rand.Next(6)]);


Console.WriteLine(NameandFlav["Tim"]);

// Loop through the dictionary and print out each user's name and their associated ice cream flavor. 
foreach(KeyValuePair<string,string> entry in NameandFlav) {
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}