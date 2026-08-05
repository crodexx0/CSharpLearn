//Basic for statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Use the break keyword to break the iteration statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

/*
// Loop through each element of an array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


// Limitation of the foreach statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
// Display "Cannot assign to name because it is a 'foreach iteration variable'" error.
*/


// Overcoming the limitation of the foreach statement using the for statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


/*
CHALLENGE ACTIVITY: FIZZBUZZ CHALLENGE

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine($"{i} {(i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : (i % 3 == 0 ? "Fizz" : (i % 5 == 0 ? "Buzz" : "")))}");
}