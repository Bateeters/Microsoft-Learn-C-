/*
Project overview
You're working on the Contoso Pets application, an application that helps place pets in new homes. The specifications for your application are:

Store application data in a multidimensional string array named ourAnimals.

The ourAnimals array includes the following "pet characteristics" for each animal:
    Pet ID #.
    Pet species (cat or dog).
    Pet age (years).
    A description of the pet's physical condition/characteristics.
    A description of the pet's personality.
    The pet's nickname.

Implement a sample dataset that represents dogs and cats currently in your care.

Display menu options to access the main features of the application.


The main features enable the following tasks:

    List the pet information for all animals in the ourAnimals array.

    Add new animals to the ourAnimals array. The following conditions apply:
        The pet species (dog or cat) must be entered when a new animal is added to the ourAnimals array.
        A pet ID must be programmatically generated when a new animal is added to the ourAnimals array.
        Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
        An animal's nickname and personality may be unknown when a pet first arrives.

    Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.

    Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).

    Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).

    Edit an animal’s personality description (a pet may behave differently after spending more time in our care).

    Display all cats that meet user specified physical characteristics.

    Display all dogs that meet user specified physical characteristics.

An initial version of the application has already been completed.
The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

    The code declares variables used to collect and process pet data and menu item selections.

    The code declares the ourAnimals array.

    The code uses a for loop around an if-elseif-else construct to populate the ourAnimals array with a sample dataset.

    The code displays the following main menu options for user selection:

        List all of our current pet information.
        Assign values to the ourAnimals array fields.
        Ensure animal ages and physical descriptions are complete.
        Ensure animal nicknames and personality descriptions are complete.
        Edit an animal’s age.
        Edit an animal’s personality description.
        Display all cats with a specified characteristic.
        Display all dogs with a specified characteristic.


Enter menu item selection or type "Exit" to exit the program

The code reads the user's menu item selection and displays a message echoing their selection.


Your goal is to develop the features that implement the first two menu options. To achieve this goal, you'll complete the following tasks:

    Update the code that's used to create the sample data for the app.
    Construct a loop around the main menu and create a selection statement that establishes a code branch for each menu option.
    Write the code to display all ourAnimals array data (menu option 1).
    Build a loop for entering new ourAnimals array data (menu option 2 - part 1).
    Write code to read and save new ourAnimals array data (menu option 2 - part 2).

You'll test your application at each stage of the development process.
*/

// ========================================================================
// STARTING CODE
// ========================================================================

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    // readResult = Console.ReadLine();

    switch(menuSelection)
    {
        case "1":
            // List all of our current pet information
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // List a new animal friend to the ourAnimals array
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality are complete
            Console.WriteLine("Challenge Project - Please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Change animal's age
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Update an animals personality
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Specifically show Cats only
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Specifically show Dogs only
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }
} while (menuSelection != "exit");
