/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

Throws an error because you cannot add an integer and a string directly. You need to convert the string to an integer before performing the addition. You can do this using casting or conversion methods like `int.Parse()` or `Convert.ToInt32()`.
*/



int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
// Does not throw an error because the integer is implicitly converted to a string during the concatenation operation. The output will be "24" as a string.



int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal1 = myInt;
Console.WriteLine($"decimal: {myDecimal1}");
// Since any int value can easily fit inside of a decimal, the compiler performs the conversion.
// This is widening conversion, converting a value from a data type that could hold less information to a data type that can hold more information.



// Perform a Cast
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt1 = (int)myDecimal2;
Console.WriteLine($"int: {myInt1}");
//To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert (example: (int)myDecimal). You perform an explicit conversion to the defined cast data type (int).



/* 
Narrow Conversion 
  - converting a value from a data type that can hold more information to a data type that can hold less information.
  - you may lose information such as precision (that is, the number of values after the decimal point).
  - When you know you're performing a narrowing conversion, you need to perform a cast.
  - Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.
  - If you're unsure whether you lose data in the conversion, write code to perform a conversion in two different ways and observe the changes.
  - Developers frequently write small tests to better understand the behaviors, as illustrated with the next sample.
*/
decimal myDecimal3 = 1.23456789m;
float myFloat1 = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat1}");



// Use ToString() to convert a number to a string
int firstNum = 5;
int secondNum = 7;
string message = firstNum.ToString() + secondNum.ToString();
Console.WriteLine(message);



// Convert a string to an int using the Parse() helper method
string firstNum2 = "5";
string secondNum2 = "7";
int sum = int.Parse(firstNum2) + int.Parse(secondNum2);
Console.WriteLine(sum);



// Convert a string to a int using the Convert class
string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result1);



// Compare casting and converting a decimal into an int
int value11 = (int)1.5m; // casting truncates
Console.WriteLine(value11);

int value22 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value22);



/*
string name = "Bob";
Console.WriteLine(int.Parse(name));
*/
 // The code above throws an error because the string "Bob" cannot be converted to an integer.
 
string value33 = "102";
int result2 = 0;
if (int.TryParse(value33, out result2))
{
   Console.WriteLine($"Measurement: {result2}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result2}");



string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;
string message2 = "";
  
foreach (string value in values)
{
  if (float.TryParse(value, out float result3))
  {
    total += result3;
  } else
  {
    message2 += value;
  }
}
Console.WriteLine(message2);
Console.WriteLine($"Total: {total}");



int value44 = 11;
decimal value55 = 6.2m;
float value66 = 4.3f;


// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value44 by value55, display the result as an int: {Convert.ToInt32(value44 / value55)}");

// Your code here to set result2
Console.WriteLine($"Divide value55 by value66, display the result as a decimal: {value55 / (decimal)value66}");

// Your code here to set result3
Console.WriteLine($"Divide value66 by value44, display the result as a float: {value66 / (float)value44}");
