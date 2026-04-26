/*

Write code that generates three random numbers and displays them in output

Here is the starting code for this exercise:



Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");



To begin, you create a new instance of the System.Random class and store a reference to the object in a variable named dice. 
Then, you call the Random.Next() method on the dice object three times, providing both the lower and upper bounds to restrict 
the possible values between 1 and 6 (the upper bound is exclusive). You save the three random numbers in the variables roll1, 
roll2, and roll3, respectively.

Next, you sum the three dice rolls and save the value into an integer variable named total.

Finally, you use the WriteLine() method to display the three values using string interpolation.

When you run the code, you should see the following message (the numbers will be different).

Output

Dice roll: 4 + 5 + 2 = 11

*/

Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
    Console.WriteLine($"Total with bonus: {total}");
}

if((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples ! +6 bonus to total!");
    total += 6;
    Console.WriteLine($"Total with bonus: {total}");
}

if (total >= 15)
{
    Console.WriteLine("You win!");
} else
{
    Console.WriteLine("You lose!");
}