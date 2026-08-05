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
