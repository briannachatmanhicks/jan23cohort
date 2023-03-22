// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1. Iterate and print values
// Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
static void PrintList(List<string> MyList)
{
    foreach(var test in MyList){
        Console.WriteLine(test);
    }
    // Your code here
}
PrintList(TestStringList);



// 2. Print Sum
// Given a List of integers, calculate and print the sum of the values.
List<int> TestIntList = new List<int>() {2,7,12,9,3};
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i < IntList.Count; i++){
        sum = sum + IntList[i];
    }
    Console.WriteLine(sum);
    // Your code here
}
// You should get back 33 in this example
SumOfNumbers(TestIntList);



// 3. Find Max
// Given a List of integers, find and return the largest value in the List.
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
static int FindMax(List<int> IntList)
{
    int lar = IntList[0];
    for (int i = 0; i < IntList.Count; i++){
        if (lar < IntList[i]) {
            lar = IntList[i]; 
        }
    }
    return lar;
    // Your code here
}
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));



// 4. Square the Values   ///////////////////////////////////////////////////////
// Given a List of integers, return the List with all the values squared.
static List<int> SquareValues(List<int> IntList){
    for (int i = 0; i < IntList.Count; i++){
        Console.WriteLine($"before {IntList[i]}");
        IntList[i] = IntList[i] * IntList[i];
        Console.WriteLine($"after {IntList[i]}");
    }
    foreach (var item in IntList){
        Console.WriteLine(item);
    }
    return IntList;
    }
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
Console.WriteLine(SquareValues(TestIntList3));



// 5. Replace Negative Numbers with 0
// Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++) {
        Console.WriteLine(IntArray[i]);
        if (IntArray[i] < 0) {
            IntArray[i] = 0;
        }
    }
    foreach(var item in IntArray) {
        Console.WriteLine(item);
    }
    // Your code here
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);



// 6. Print Dictionary
// Given a dictionary, print the contents of the said dictionary.
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(KeyValuePair<string,string> entry in MyDictionary){
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
    // Your code here
}
PrintDictionary(TestDict);



// 7. Find Key
// Given a search term, return true or false whether the given term is a key in a dictionary.
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool flag = false;
    if(MyDictionary.ContainsKey(SearchTerm)){
        flag = true;
    }
    return flag;
    // Your code here
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));



// 8. Generate a Dictionary
// Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
List<int> TestIntList8 = new List<int>() {6,12,7,10};
List<string> TestName = new List<string>() {"Julie", "Harold", "James", "Monica"};
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // string aName;
    // int anAge;
    Dictionary<string,int> ages = new Dictionary<string,int>();

    for (int i = 0; i < Names.Count; i++) {
        string aName = Names[i];
        int anAge = Numbers[i];
        
        ages[aName] = anAge;
    }
    // foreach(KeyValuePair<string,int> entry in ages){
    //     Names.Add(entry.Key);
    //     Numbers.Add(entry.Value);
    // }
    return ages;
    // Your code here
}
foreach (KeyValuePair<string,int> entry in GenerateDictionary(TestName, TestIntList8)){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here