// Create an instance of the Random class named dice
Random dice = new();

// Use the dice.Next(1, 7) method to assign a random value to an integer named roll
// the Next() method includes a method signature that accepts two parameters of type int.
// Used to configure lower and upper boundaries for the random number returned.
int roll = dice.Next(1,7);

// Use Console.WriteLine() method to print the value of roll.
Console.WriteLine(roll);




// Overloaded methods
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
// Each WriteLine() being called here is a separate overloaded version of the WriteLine() method.



Random dice2 = new();

// No upper or lower boundary, can return any value ranging from 0 to 2,147,483,647 (the max value an int can store).
int roll1 = dice2.Next();

// Only one parameter means you define the upper boundary. returns anything from 0 to 100.
int roll2 = dice2.Next(101);

// Both lower and upper boundaries are defined, returns a value from 50 to 100.
int roll3 = dice2.Next(50,101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

dice2.Next()