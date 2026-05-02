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
int value = 10;
if (flag)
{
    Console.WriteLine($"Inside if block: {value}");
}

Console.WriteLine($"Outside if block: {value}");