/*
Calculate Celsius given the current temperature in Fahrenheit

use the following line of code:

int fahrenheit = 94;


To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).

Display the result of the temperature conversion in a formatted message

Combine the variables with literal strings passed into a series of Console.WriteLine() commands to form the complete message.

When you're finished, the message should resemble the following output:

Output
The temperature is 34.444444444444444444444444447 Celsius.
*/

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32)*(5.0m/9);

Console.WriteLine($"The temperature is {celsius} Celsius.");