/*
FizzBuzz rules to implement in your code:

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.


Important:
You need to understand how to use the % remainder operator to determine if a number is divisible 
by another number evenly. We covered this in the module "Perform basic operations on numbers in C#".


Output

1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
.
.
.
 Note

We only show the first 22 values, but your output should continue to 100. As you can see, the number 15 
is divisible by both 3 and 5, so we print FizzBuzz next to that number.
*/


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine(i);
}