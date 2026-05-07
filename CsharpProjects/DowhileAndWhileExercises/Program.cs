/*
Code Exercise 1
Here are the conditions to implement:

Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Inside the iteration block:
    Your solution must use a Console.ReadLine() statement to obtain input from the user.
    Your solution must ensure that the input is a valid representation of an integer.
    If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

For example, when you run your application, it should reject input values such as "two" and "2", but it should accept an input value of "7".

The console output should look similar to the following:

Output
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/


/*
// SOLUTION
string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber && numericValue >=5 && numericValue <= 10)
        continue;
    else if (validNumber)
    {
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        validNumber = false;
    }
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted");
*/

/*
Code Exercise 2

Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Run your application and verify that your code validates user input based on the specified requirements.

For example, when you run your application, it should reject an input value such as "Admin", but it should accept an input value of " administrator ".

The console output for this example should look similar to the following:

Output
    Enter your role name (Administrator, Manager, or User)
    Admin
    The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
    Administrator
    Your input value (Administrator) has been accepted.
*/
string? userRole;
string userCompareValue;
bool validRole = false;

Console.WriteLine("Enter your role name (Administrator, Manger, or User)");

do
{
    userRole = Console.ReadLine();
    userCompareValue = userRole.Trim().ToLower();


    if (userCompareValue != "administrator" && userCompareValue != "manager" && userCompareValue != "user")
    {
        Console.WriteLine($"The role name that you entered, {userRole} is not valid. Enter your role name (Administrator, Manager, or User");
    }
    else
    {
        validRole = true;
    }
} while (validRole == false);

Console.WriteLine($"Your input value ({userRole}) has been accepted.");

