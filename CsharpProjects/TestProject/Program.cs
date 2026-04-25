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