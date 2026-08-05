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
