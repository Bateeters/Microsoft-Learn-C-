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

int value = 10;
if (flag)
{
    Console.WriteLine($"Inside if block: {value}");
}

Console.WriteLine($"Outside if block: {value}");