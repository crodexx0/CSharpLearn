/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
string pangram2 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram2.Contains("fox"));
Console.WriteLine(!pangram2.Contains("cow"));
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/



/* 
CONDITIONAL OPERATOR
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>


int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/


/*
//Code challenge: display the result of a coin flip
Random coin = new Random();
int result = coin.Next(2);
Console.WriteLine(result);
Console.WriteLine($"Coin Toss Result: {(result == 1 ? "Heads" : "Tails" )}");
Random coin = new Random();
Console.WriteLine($"Coin Toss Result: {(coin.Next(2) == 1 ? "Heads" : "Tails")}");
*/



string permission = "Admin|Manager";
int level = 20;
Console.WriteLine((permission.Contains("Admin") && level > 55) ? "Welcome, Super Admin user." : (permission.Contains("Admin") && level <= 55) ? "Welcome, Admin user." : (permission.Contains("Manager") && level >= 20) ? "Contact an Admin for access." : (permission.Contains("Manager") && level < 20) ? "You do not have sufficient privileges." : "You do not have sufficient privileges.");
