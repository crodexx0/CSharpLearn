/*
//This code uses a `do-while` loop to generate random numbers between 1 and 10 until the number 7 is generated.
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/



/*
// This generates and prints random numbers between 1 and 10 until a number less than 3 is generated.
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/



// This code generates random numbers between 1 and 10, printing them unless the number is 8 or higher, and continues until the number 7 is generated.
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);



/* 
CHALLENGE ACTIVITY: implement the game rules

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int monsterHealth = 10;
int heroHealth = 10;

int monsterDamage = 0;
int heroDamage = 0;

do
{
    monsterDamage = random.Next(1, 11);
    heroDamage = random.Next(1, 11);

    Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHealth -= heroDamage} health.");
    if (monsterHealth <= 0) continue;
    Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHealth -= monsterDamage} health.");
} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");



/* 
CHALLENGE ACTIVITY: differentiate between do and while iteration statements. Three separate coding projects.

The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
The do-while statement: conditionally executes its body one or more times.
The while statement: conditionally executes its body zero or more times.
*/

/*
// Project 1: validate integer input

string? userInput;
int userInputValue = 0;
bool isValidInput = false;

Console.WriteLine("Please enter an integer between 5 and 10: ");

do
{
    userInput = Console.ReadLine();
    

    if (userInput != null)
    {
        isValidInput = int.TryParse(userInput, out userInputValue);
        // int.TryParse() method can be used to convert a string value to an integer. 
        // It uses two parameters, a string that will be evaluated and the name of an integer variable that will be assigned a value.

        if (isValidInput == true)
        {
            if (userInputValue >= 5 && userInputValue <= 10)
            {
                isValidInput = true;
            }
            else
            {
                isValidInput = false;
                Console.WriteLine($"You have entered {userInputValue}. Please enter an integer between 5 and 10: ");
            }
        }
        else
            Console.WriteLine("Sorry, you have entered an invalid number. Please try again.");
    }
    else
        Console.WriteLine("Sorry, you have entered an invalid number. Please try again.");
    
} while (isValidInput == false);

Console.WriteLine($"Your input value ({userInputValue}) has been accepted.");

// The code above validates user input for an integer value between 5 and 10. It uses a do-while loop to repeatedly prompt the user until valid input is received, checking if the input can be parsed as an integer and if it falls within the specified range.
*/



/*
// Project 2: validate string input
string? userInput;
bool isValidInput = false;

Console.WriteLine("Choose your role (Administrator, Manager, User): ");

do
{
    userInput = Console.ReadLine();
    string checkUserInput = userInput?.Trim(); // Trim() method removes all leading and trailing white-space characters from the current string.
    checkUserInput = checkUserInput?.ToLower(); // ToLower() method converts a string to lowercase.

    if (userInput != null)
    {
        if (checkUserInput == "administrator" || checkUserInput == "manager" || checkUserInput == "user")
        {
            isValidInput = true;
            Console.WriteLine($"Your input value ({userInput}) has been accepted.");
        }
        else
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
    else
        Console.WriteLine("Sorry, you have entered an invalid role. Please try again.");
    
} while (isValidInput == false);

// The code above validates user input for a role name, ensuring that the input is one of the specified valid roles. It uses a do-while loop to repeatedly prompt the user until valid input is received, trimming whitespace and converting the input to lowercase for comparison.
*/



// Project 3: processes the contents of a string array

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];

    periodLocation = myString.IndexOf('.'); 
    // IndexOf() method returns the index of the first occurrence of a specified character or string within the current string.


    if (periodLocation > 0)
    {
        do
        {
            
            string outputString = myString.Substring(0, periodLocation + 1); 
            // Substring() method retrieves a substring from the current string. It uses two parameters, the starting index and the length of the substring.
            outputString = outputString.Trim('.', ' '); 
            // Trim() method removes all leading and trailing white-space characters from the current string.
            Console.WriteLine(outputString);
            myString = myString.Remove(0, periodLocation + 1);
            // Remove() method removes a specified number of characters from the current string, starting at a specified index.
            periodLocation = myString.IndexOf('.');

            if (periodLocation < 0 && myString.Length > 0)
            {
                Console.WriteLine(myString.Trim());
            }

        } while (periodLocation > 0);
    } else
    {
        Console.WriteLine(myString);
    }
}

// The code above processes the contents of a string array, splitting each string into sentences based on the period character. It uses a for loop to iterate through each string in the array and a do-while loop to extract and print each sentence until there are no more periods left in the string. If there are no periods, it simply prints the entire string.