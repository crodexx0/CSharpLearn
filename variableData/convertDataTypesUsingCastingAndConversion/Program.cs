/*
================================================================================
C# DATA TYPE CASTING AND CONVERSIONS STUDY GUIDE & EXAMPLES
================================================================================
This file demonstrates various ways to convert and cast data types in C#.
We explore the differences between implicit/explicit conversions, widening/narrowing 
conversions, casting, parsing, using the Convert class, and TryParse.
*/

// ================================================================================
// SECTION 1: IMPLICIT VS. EXPLICIT CONVERSIONS & COMPILER ERRORS
// ================================================================================

/*
--- STUDY NOTE: Direct addition of mismatching types is illegal ---
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

EXPLANATION:
The code above throws a compile-time error: "Cannot implicitly convert type 'string' to 'int'".
C# is a strongly-typed language. The compiler protects you from accidentally performing
unsupported math operations on strings. To make this work, you must explicitly parse or convert
the string to an integer before the addition, e.g., using `int.Parse()` or `Convert.ToInt32()`.
*/

Console.WriteLine("--- SECTION 1: IMPLICIT STRING CONCATENATION ---");
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine($"Result of first + second: {result}");
/*
EXPLANATION:
This does NOT throw an error because of implicit string conversion during concatenation.
When using the '+' operator where at least one operand is a string, the C# compiler 
automatically invokes the implicit conversion of the other operand(s) to a string and
concatenates them. 
- Input: int (2) + string ("4")
- Implicit Conversion: string ("2") + string ("4")
- Output: "24" (as a string)
*/


// ================================================================================
// SECTION 2: WIDENING CONVERSIONS (IMPLICIT)
// ================================================================================
Console.WriteLine("\n--- SECTION 2: WIDENING CONVERSIONS ---");
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal1 = myInt;
Console.WriteLine($"decimal: {myDecimal1}");
/*
EXPLANATION:
- What is Widening? 
  Converting a value from a data type that holds LESS information (smaller range/precision)
  to a data type that can hold MORE information (larger range/precision).
- Implicit Conversion: 
  Since any 'int' value can easily and completely fit inside of a 'decimal' without any 
  loss of information or precision, the C# compiler performs this conversion automatically 
  (implicitly) for you. It is entirely safe.
*/


// ================================================================================
// SECTION 3: NARROWING CONVERSIONS & EXPLICIT CASTING
// ================================================================================
Console.WriteLine("\n--- SECTION 3: EXPLICIT CASTING (NARROWING) ---");
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt1 = (int)myDecimal2;
Console.WriteLine($"int: {myInt1}");
/*
EXPLANATION:
- What is Narrowing?
  Converting a value from a data type that holds MORE information (larger range/precision)
  to a data type that holds LESS information (smaller range/precision).
- Risk of Narrowing:
  You may lose information, such as precision (fractional values after the decimal point)
  or cause an overflow if the source value is larger than the destination type's capacity.
- What is Casting?
  Because of the risk of data loss, the compiler WILL NOT perform narrowing implicitly. 
  Instead, you must perform an explicit conversion called a CAST.
  To perform a cast, place the destination data type inside parentheses `()` directly in 
  front of the variable or value to be converted (e.g., `(int)myDecimal2`).
  By casting, you are telling the C# compiler: "I am aware that precision or data may be 
  lost here, but I explicitly accept this outcome and want to proceed."
*/


/* 
--- STUDY NOTE: Narrowing Conversion Precision Loss ---
Below is a demonstration of narrowing conversion from a high-precision 'decimal'
to a lower-precision 'float' (System.Single).
*/
Console.WriteLine("\n--- SECTION 3B: PRECISION LOSS IN CASTING ---");
decimal myDecimal3 = 1.23456789m;
float myFloat1 = (float)myDecimal3;

Console.WriteLine($"Decimal (High-precision 128-bit): {myDecimal3}");
Console.WriteLine($"Float   (Lower-precision 32-bit): {myFloat1}");
/*
EXPLANATION:
A decimal can maintain up to 28-29 significant digits of precision, whereas a float only 
supports about 6-9 digits of precision. When casting `decimal` to `float`, we explicitly
instruct the compiler to truncate or round the extra decimal precision to fit into 32 bits.
*/


// ================================================================================
// SECTION 4: CONVERTING TO STRING USING ToString()
// ================================================================================
Console.WriteLine("\n--- SECTION 4: USING ToString() ---");
int firstNum = 5;
int secondNum = 7;
string message = firstNum.ToString() + secondNum.ToString();
Console.WriteLine($"Message: {message}");
/*
EXPLANATION:
Every C# object inherits from the base `System.Object` class and has access to the 
`.ToString()` method. Calling `.ToString()` on a numeric value converts its literal representation 
to a string. 
- `firstNum.ToString()` produces "5"
- `secondNum.ToString()` produces "7"
- Concatenating "5" + "7" yields "57" rather than doing mathematical addition (which would be 12).
*/


// ================================================================================
// SECTION 5: PARSING STRINGS TO NUMBERS USING Parse()
// ================================================================================
Console.WriteLine("\n--- SECTION 5: USING int.Parse() ---");
string firstNum2 = "5";
string secondNum2 = "7";
int sum = int.Parse(firstNum2) + int.Parse(secondNum2);
Console.WriteLine($"Sum using Parse: {sum}");
/*
EXPLANATION:
- What is Parsing?
  Parsing is a process of analyzing a string and converting it into a structured data type.
  Most primitive numeric types (int, double, decimal, float, etc.) have a static `.Parse()` 
  method designed specifically for converting a string representation of a number into that type.
- Caveat: 
  The string must contain a valid, recognizable representation of that specific data type. 
  If the string is malformed or contains letters/symbols, `.Parse()` will throw a runtime 
  exception (FormatException), causing the application to crash if not caught.
*/


// ================================================================================
// SECTION 6: USING THE Convert CLASS
// ================================================================================
Console.WriteLine("\n--- SECTION 6: USING THE Convert CLASS ---");
string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine($"Product using Convert: {result1}");
/*
EXPLANATION:
The static `System.Convert` class provides a comprehensive set of methods to convert a value 
from one base data type to another.
- `Convert.ToInt32()` converts the string value to a 32-bit signed integer.
- Key Advantage: Unlike `.Parse()`, the `Convert` methods are safer when dealing with `null`.
  If you pass `null` to `int.Parse()`, it throws an ArgumentNullException. 
  If you pass `null` to `Convert.ToInt32()`, it returns `0` safely without crashing.
*/


// ================================================================================
// SECTION 7: COMPARING CASTING VS. CONVERSION (TRUNCATION VS. ROUNDING)
// ================================================================================
Console.WriteLine("\n--- SECTION 7: CASTING VS. CONVERSION (TRUNCATION VS. ROUNDING) ---");
int value11 = (int)1.5m; 
Console.WriteLine($"Casted (int)1.5m: {value11}");

int value22 = Convert.ToInt32(1.5m); 
Console.WriteLine($"Converted ToInt32(1.5m): {value22}");
/*
EXPLANATION:
There is an extremely important functional difference between casting and converting:
1. Casting (e.g., `(int)1.5m`):
   Casting truncates the fractional part. It completely discards any numbers after the decimal point, 
   effectively rounding towards zero. Thus, `1.5m` becomes `1`.
2. Converting (e.g., `Convert.ToInt32(1.5m)`):
   Converting performs rounding to the nearest integer.
   - Note: C#'s `Convert` class uses "Banker's Rounding" (round-to-even) by default.
     When a number is exactly halfway between two integers (like 1.5 or 2.5), it rounds to the 
     nearest *even* integer.
     - `Convert.ToInt32(1.5m)` rounds up to `2`
     - `Convert.ToInt32(2.5m)` rounds down to `2`
     This minimizes statistical bias during large-scale summation operations.
*/


// ================================================================================
// SECTION 8: SAFE PARSING WITH TryParse()
// ================================================================================
Console.WriteLine("\n--- SECTION 8: TRYPARSE FOR SAFE ERROR-FREE CONVERSION ---");
/*
--- STUDY NOTE: Parse failure crashes the program ---
string name = "Bob";
Console.WriteLine(int.Parse(name));

EXPLANATION:
If you uncomment the above block, C# will throw a System.FormatException: "The input string 
'Bob' was not in a correct format." 
*/

string value33 = "102";
int result2 = 0;

// TryParse returns a boolean indicating success/failure, and outputs the result into an 'out' variable.
if (int.TryParse(value33, out result2))
{
   Console.WriteLine($"Measurement successfully parsed: {result2}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result2}");
/*
EXPLANATION:
- How does `TryParse()` work?
  Instead of throwing an exception when parsing fails, `TryParse` returns a boolean (`true` or `false`).
- What is an `out` parameter?
  The `out` keyword allows a method to pass a variable by reference to return more than one value.
  If parsing succeeds:
    - `int.TryParse` returns `true`.
    - The parsed numeric value is placed in the `result2` variable.
  If parsing fails:
    - `int.TryParse` returns `false`.
    - The `result2` variable is set to its default value (which is `0`).
  This allows you to write robust code that gracefully handles invalid user input without crashing.
*/


// ================================================================================
// SECTION 9: ARRAY LOOP & TRYPARSE PRACTICE
// ================================================================================
Console.WriteLine("\n--- SECTION 9: PARSING MIXED-TYPE ARRAYS WITH TRYPARSE ---");
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;
string message2 = "";
  
foreach (string value in values)
{
  // Try to parse the string value as a float
  if (float.TryParse(value, out float result3))
  {
    // If successful, accumulate the numerical value into total
    total += result3;
  } 
  else
  {
    // If parsing fails (meaning it's alphabetical/non-numeric text), concatenate it to message2
    message2 += value;
  }
}
Console.WriteLine($"Concatenated string elements: {message2}");
Console.WriteLine($"Total of numeric elements   : {total}");


// ================================================================================
// SECTION 10: CHALLENGES & MATH WITH MULTIPLE DATA TYPES
// ================================================================================
Console.WriteLine("\n--- SECTION 10: CHALLENGES & MIXED-TYPE ARITHMETIC ---");
int value44 = 11;
decimal value55 = 6.2m;
float value66 = 4.3f;

// --- Challenge 1 ---
// Task: Divide value44 by value55, display the result as an int (rounding to nearest integer, not truncating)
// Execution: 
// 1. Dividing value44 (int) by value55 (decimal) requires casting value44 to decimal first (widening conversion).
//    Operation: 11.0m / 6.2m = 1.7741935483870967741935483871m
// 2. We use Convert.ToInt32() to perform Banker's Rounding to the nearest integer.
//    1.774... rounds to the nearest integer, which is 2.
Console.WriteLine($"Divide value44 by value55, display the result as an int: {Convert.ToInt32(value44 / value55)}");

// --- Challenge 2 ---
// Task: Divide value55 by value66, display the result as a decimal
// Execution:
// 1. Division with float and decimal directly is not allowed. We must explicitly cast value66 (float) to decimal.
//    Operation: 6.2m / (decimal)4.3f = 1.4418604169720336214476140556m
Console.WriteLine($"Divide value55 by value66, display the result as a decimal: {value55 / (decimal)value66}");

// --- Challenge 3 ---
// Task: Divide value66 by value44, display the result as a float
// Execution:
// 1. Division of float and int can be performed implicitly (int is implicitly widened to float).
//    We can also do it explicitly for clarity: value66 / (float)value44.
//    Operation: 4.3f / 11.0f = 0.3909091f
Console.WriteLine($"Divide value66 by value44, display the result as a float: {value66 / (float)value44}");
