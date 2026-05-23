int[] data;
data = new int[3];

// or you can do it in one line
int[] data2 = new int[3];



string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);


int val_A = 2;
int val_B = val_A; // val_B is now a copy of val_A, they are independent of each other
val_B = 5; // changing val_B does not affect val_A, they are value types

Console.WriteLine("\n--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");
