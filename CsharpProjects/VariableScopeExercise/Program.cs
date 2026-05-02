bool flag = true;

/*
if (flag)
{
    int value = 10;
    Console.WriteLine(value);
}

// The below line of code causes a compile error because "value" is only defined INSIDE the if block
// Console.WriteLine(value);
*/

// This works because "value" is defined in the same scope as the Console.WriteLine statements
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside if block: {value}");
}

// value is now updated after the if statement runs. It'll prints the updated value for the 2nd line
value = 10;
Console.WriteLine($"Outside if block: {value}");