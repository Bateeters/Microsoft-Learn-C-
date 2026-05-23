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



int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A; // ref_B is now a reference to the same array as ref_A, they are not independent of each other
// They both point to the same memory location.
ref_B[0] = 5; // changing ref_B also changes ref_A, they are reference types

Console.WriteLine("\n--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");