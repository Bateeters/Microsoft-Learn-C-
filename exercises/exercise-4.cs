// Addition of two ints
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// mix data types to force implicit type conversions
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// adding numbers while still concatenating strings
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// try to avoid this if you can but know that it is possible

// Examples of all the basic math operations:
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum); // 12
Console.WriteLine("Difference: " + difference); // 2
Console.WriteLine("Product: " + product); // 35
Console.WriteLine("Quotient: " + quotient); // 1
// the valuse after the decimal are truncated from the quotient since it's an int (always a whole number)

// Example of how to see division correctly working
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}"); // 1.4

// Cast results of integer division (change results to a decimal when using two ints)
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient); // 1.4

// determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // 0 (this means there is no remainder and the dividend is divisible by the divisor.)
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // 2

/* 
* Order of operations (PEMDAS) 
* Parentheses
* Exponents
* Multiplication and Division (left to right)
* Addition and Subtraction (left to right)
*/
int value1 = 3+4*5;
int value2 = (3+4)*5;
Console.WriteLine(value1); // 23
Console.WriteLine(value2); // 35

// increment and decrement values
int value = 1;

value = value + 1;
Console.WriteLine($"First increment: {value}"); // 2

value += 1;
Console.WriteLine($"Second increment: {value}"); // 3

value++;
Console.WriteLine($"Third increment: {value}"); // 4

value = value - 1;
Console.WriteLine($"First decrement: {value}"); // 3

value -= 1;
Console.WriteLine($"Second decrement: {value}"); // 2

value--;
Console.WriteLine($"Third decrement: {value}"); // 1


// The position of the icrement and decrement operators matters
int value = 1;
value++;
Console.WriteLine($"First: {value}"); // 2
Console.WriteLine($"Second: {value++}"); // 2 (write value THEN increment)
Console.WriteLine($"Third: {value}"); // 3
Console.WriteLine($"Fourth: {++value}"); // 4 (increment THEN write value)