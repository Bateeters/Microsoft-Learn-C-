/*
Starting code:

    int[] numbers = { 4, 8, 15, 16, 23, 42 };

    foreach (int number in numbers)
    {
        int total;

        total += number;

        if (number == 42)
        {
        bool found = true;

        }

    }

    if (found) 
    {
        Console.WriteLine("Set contains 42");

    }

    Console.WriteLine($"Total: {total}");

When you have completed the required code edits, your application should produce the following output:

Set contains 42
Total: 108


Complete the code updates required so that the existing Console.WriteLine() statements produce the desired output.

Variable scope may need to be adjusted.

Optimize your code for readability.

Depending on the amount of whitespace that you include and some other factors, you should have around 17 lines of code.
*/


int[] numbers = { 4, 8, 15, 16, 23, 42 };

bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");