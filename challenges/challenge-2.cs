/* Store the following values in variables:

Bob
3
34.4

These variables should be given names that reflect their purpose.

Make sure you select the correct data type for each of the 
variables based on the type of data it will hold.

Finally, you'll combine the variables with literal strings passed 
into a series of Console.Write() commands to form a complete message.

Write code to display the following message:

Output
Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

No matter how you do it, your code should produce the specified output.
*/

string firstName = "Bob";
int messageCount = 3;
decimal temperature = 34.4m;

Console.Write("Hello ");
Console.Write(firstName);
Console.Write("! You have ");
Console.Write(messageCount);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");