// Declare an array that is of the string data type 
// called "fraudulentOrderIDs"
// that can hold 3 string values
/*
string[] fraudulentOrderIDs = new string[3];

// Initialize values to the array elements
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Attempting to access an index outside of array
// fraudulentOrderIDs[3] = "D000";
*/

// Declare and initialize array in single statement
// You may also see {values} used instead of [values] (it's older syntax)
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of an array element
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Length property of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent order to process.");

// Looping through array elements
string[] names = [ "Rowena", "Robin", "Bao" ];
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [ 200, 450, 700, 175, 250 ];
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

