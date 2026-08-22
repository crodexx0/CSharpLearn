// ==========================================
// METHODS USED IN THIS FILE & THEIRS SIGNATURES:
// ==========================================
//
// 1. Console.WriteLine()
//    - Description: Writes data to the standard output stream, followed by a line terminator.
//    - Overloads used here:
//      - Console.WriteLine(bool value): Outputs "True" or "False" representation of the boolean.
//      - Console.WriteLine(int value): Outputs the string representation of the integer value.
//      - Console.WriteLine(string value): Outputs the string directly.
//
// 2. String.Contains(string value)
//    - Description: Checks whether a specified substring occurs within a string instance.
//    - Required Argument: 'string value' - the substring to search for.
//    - Return Value: bool ('true' if found, 'false' otherwise).
//
// 3. Random.Next(int maxValue)
//    - Description: Generates a non-negative random integer that is less than the specified maximum.
//    - Required Argument: 'int maxValue' - the exclusive upper bound of the random number to be generated (must be >= 0).
//    - Return Value: int (e.g., Next(2) returns 0 or 1).
//
// ==========================================


// ----------------------------------------------------
// CODE GROUP 1: Searching Substrings with String.Contains()
// ----------------------------------------------------
// How it works:
// - It defines a pangram (a sentence containing every letter of the alphabet).
// - It uses String.Contains() to check for specific words inside the pangram.
// Expected Output:
// - True (since "fox" is in the sentence)
// - False (since "cow" is not in the sentence)
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));


// ----------------------------------------------------
// CODE GROUP 2: Logical Negation Operator (!)
// ----------------------------------------------------
// How it works:
// - It uses the logical negation operator (!) to invert boolean results returned by String.Contains().
// Expected Output:
// - False (original is True, negated is False)
// - True (original is False, negated is True)
string pangram2 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram2.Contains("fox"));
Console.WriteLine(!pangram2.Contains("cow"));


// ----------------------------------------------------
// CODE GROUP 3: Integer Inequality Comparison Block
// ----------------------------------------------------
// How it works:
// - It compares two integer variables 'a' and 'b' using the inequality operator (!=).
// Expected Output:
// - True (since 7 is not equal to 6)
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True


// ----------------------------------------------------
// CODE GROUP 4: String Inequality Comparison Block
// ----------------------------------------------------
// How it works:
// - It compares two string variables 's1' and 's2' using the inequality operator (!=).
// Expected Output:
// - False (since "Hello" is equal to "Hello", so 'not equal' is False)
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False





// ----------------------------------------------------
// CODE GROUP 5: Conditional (Ternary) Operator Block
// ----------------------------------------------------
// How it works:
// - Uses the conditional operator <condition> ? <value if true> : <value if false> to evaluate a discount inline.
// - Since saleAmount is 1001, the condition (1001 > 1000) is True, returning 100.
// Expected Output:
// - Discount: 100
int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");




// ----------------------------------------------------
// CODE GROUP 6: Coin Toss Simulation using Random and Ternary Operator
// ----------------------------------------------------
// How it works:
// - Instantiates a 'Random' object and gets a number (0 or 1) using Next(2).
// - Uses a ternary operator to evaluate if 'result' is 1. If 1, returns "Heads", otherwise "Tails".
// - In the second coin toss, it generates the random number and evaluates it inline in a single statement.
// Expected Output:
// - A random integer: 0 or 1
// - Coin Toss Result: Heads (if 1) or Tails (if 0)
// - Coin Toss Result: Heads (if 1) or Tails (if 0)
Random coin = new Random();
int result = coin.Next(2);
Console.WriteLine(result);
Console.WriteLine($"Coin Toss Result: {(result == 1 ? "Heads" : "Tails" )}");
Random coin2 = new Random();
Console.WriteLine($"Coin Toss Result: {(coin2.Next(2) == 1 ? "Heads" : "Tails")}");




// ----------------------------------------------------
// CODE GROUP 7: Access Control Check using Nested Ternary Operators
// ----------------------------------------------------
// How it works:
// - Evaluates user privileges based on 'permission' and 'level' using nested conditional operators.
// - Condition 1: (permission.Contains("Admin") && level > 55) -> "Admin" is present, but level (20) is not > 55. Evaluates to False.
// - Condition 2: (permission.Contains("Admin") && level <= 55) -> "Admin" is present, and level (20) is <= 55. Evaluates to True.
// - Since Condition 2 is True, the expression immediately resolves to "Welcome, Admin user." without checking the subsequent branches.
// Expected Output:
// - Welcome, Admin user.
string permission = "Admin|Manager";
int level = 20;
Console.WriteLine((permission.Contains("Admin") && level > 55) ? "Welcome, Super Admin user." : 
                  (permission.Contains("Admin") && level <= 55) ? "Welcome, Admin user." : 
                  (permission.Contains("Manager") && level >= 20) ? "Contact an Admin for access." : 
                  (permission.Contains("Manager") && level < 20) ? "You do not have sufficient privileges." : "You do not have sufficient privileges.");
