/*
CODE BLOCKS AND VARIABLE SCOPE

bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/
/*
This code displays error because if statements checks whether flag is true or false.

// Code sample 1
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/
/*
//This code doesnt display error even though value was initialized inside the if statement because condition is always true making the if statement like it wasn't even there
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/



/*
REMOVE CODE BLOCKS FROM IF STATEMENTS

When implementing an if statement that includes a single-statement code block, Microsoft recommends that you consider these conventions:

Never use single-line form (for example: if (flag) Console.WriteLine(flag);
Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.

DON'T DO THIS

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

DO THIS INSTEAD FOR READABILITY. AND USE BRACES IF A SINGLE STATEMENT BODY SPANS MULTIPLE LINES

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
*/



//CHALLENGE ACTIVITY USING VARIABLE SCOPE

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");