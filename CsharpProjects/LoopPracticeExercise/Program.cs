/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

/*
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/

/*
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
*/

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/

/*
// Looping through Array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) // Reverse loop through "names"
{
    Console.WriteLine(names[i]);
}
*/

/*
// foreach statement limitation example
foreach (var name in names)
{
    // Can't do this:
    if (name = "David") name = "Sammy";
}
*/

// but we can do it using a for loop
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") names[i] = "Sammy";
}

foreach (var name in names) Console.WriteLine(name);