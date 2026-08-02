/*

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
*/
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");