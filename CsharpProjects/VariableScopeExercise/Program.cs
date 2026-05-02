
/*
bool flag = true;

if (flag)
{
    int value = 10;
    Console.WriteLine(value);
}

// The below line of code causes a compile error because "value" is only defined INSIDE the if block
// Console.WriteLine(value);
*/


/*
// This works because "value" is defined in the same scope as the Console.WriteLine statements
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside if block: {value}");
}

// value is now updated after the if statement runs. It'll prints the updated value for the 2nd line
value = 10;
Console.WriteLine($"Outside if block: {value}");
*/


// Remove code blocks from if statements
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

// can also be written as:
if (flag)
    Console.WriteLine(flag);

// it can also be written as but it may impact readability and is not recommeneded:
if (flag) Console.WriteLine(flag);

// For Example the following is valid but can be harder to read:
string name = "steve";
if (name == "bob") Console.WriteLine("Hi Bob!");
else if (name == "steve") Console.WriteLine("Hi Steve!");
else Console.WriteLine("Hi there!");

// same code, easier to read:
if (name == "bob")
    Console.WriteLine("Hi Bob!");
else if (name == "steve")
    Console.WriteLine("Hi Steve!");
else
    Console.WriteLine("Hi there!");