/*
Starting Code:

string permission = "Admin|Manager";
int level = 55;

Your application will be using a combination of permission and level to apply/evaluate 
the business rules in this challenge scenario. Your completed solution must use permission and level.


Here are the Business Rules that your solution must satisfy:

If the user is an Admin with a level greater than 55, output the message:

Output
Welcome, Super Admin user.


If the user is an Admin with a level less than or equal to 55, output the message:

Output
Welcome, Admin user.


If the user is a Manager with a level 20 or greater, output the message:

Output
Contact an Admin for access.


If the user is a Manager with a level less than 20, output the message:

Output
You do not have sufficient privileges.


If the user isn't an Admin or a Manager, output the message:

Output
You do not have sufficient privileges.


Update your Program.cs code to accommodate each of the business rules.
*/

string permission = "Foobar";
int level = 12;

if (permission == "Admin")
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");    
    }
}
else if (permission == "Manager")
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");  
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");  
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}