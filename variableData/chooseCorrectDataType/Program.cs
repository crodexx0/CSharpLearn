Console.WriteLine("Signed integral types:");

// sbyte: 8-bit signed integer
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// short: 16-bit signed integer
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// int: 32-bit signed integer
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// long: 64-bit signed integer
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


Console.WriteLine("");


Console.WriteLine("Unsigned integral types:");

// byte: 8-bit unsigned integer
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// ushort: 16-bit unsigned integer
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// uint: 32-bit unsigned integer
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// ulong: 64-bit unsigned integer
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Signed integral types can represent both positive and negative values, while unsigned integral types can only represent non-negative values (zero and positive numbers). This means that signed types have a smaller range of positive values compared to their unsigned counterparts, as they need to allocate some of their range for negative numbers.



Console.WriteLine("");


Console.WriteLine("Floating point types:");

// float: 32-bit single-precision floating point
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// double: 64-bit double-precision floating point
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// decimal: 128-bit decimal floating point
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// "E notation" is a form of scientific notation that means "times 10 raised to the power of."
// Value like 5E+2 = 5 x 10^2 = 500



// A value type variable stores its values directly in an area of storage called the STACK.
// The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame).
// When the stack frame has finished executing, the values in the stack are removed.

// VALUE TYPE
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");
// When val_B = val_A is executed, the value of val_A is copied and stored in val_B.
// So, when val_B is changed, val_A remains unaffected.



// A reference type variable stores its values in a separate memory region called the HEAP.
// The heap is a memory area that is shared across many applications running on the operating system at the same time.
// The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value.
// The .NET Runtime stores the value, and then returns the memory address to the variable.
// When your code uses the variable, the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.

int[] data;
// At this point, data is merely a variable that could hold a reference, or rather, a memory address of a value in the heap. Because it's not pointing to a memory address, it's called a null reference.
data = new int[3];
// The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory.
// The .NET Runtime complies, and returns a memory address of the new int array.
// Finally, the memory address is stored in the variable data.
// The int array is now a reference type, and the variable data is a reference to that array in the heap.

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
// The string data type is also a reference type.
// So why a new operator wasn't used when declaring a string.
// This is purely a convenience afforded by the designers of C#. Because the string data type is used so frequently, the designers of C# wanted to make it easier to create string values without having to use the new operator.
// Behind the scenes, however, a new instance of System.String is created and initialized to "Hello World!".

// REFERENCE TYPE
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
// When ref_B = ref_A is executed, ref_B points to the same memory location as ref_A.
// So, when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location.


// CHOOSE THE RIGHT DATA TYPE

/* 
Suppose your variable should only store a number between 1 and 10,000
  - you would likely avoid BYTE and SBYTE since their ranges are too low.
  - you would likely not need INT, LONG, UINT, and ULONG because they can store more data than necessary
  - you would probably skip FLOAT, DOUBLE, and DECIMAL if you didn't need fractional values.
  - you might narrow it down to SHORT and USHORT, of which both may be viable.
  - If you're confident that a negative value would have no meaning in your application, you might choose USHORT
  - Now, any value assigned to a variable of type ushort outside of the boundary of 0 to 65535 would throw an exception, which is a good thing because it would prevent your application from storing an invalid value.
*/

/*
Suppose you want to work with a span of years between two dates. Since the application is a business application, you might determine that you only need a range from about 1960 to 2200.
  - you might think to try to work with BYTE since it can represent numbers between 0 and 255.
  - however, when you look at the built-in methods on the System.TimeSpan and System.DateTime classes, you realize they mostly accept values of type DOUBLE and INT.
  - if you choose SBYTE, you'll constantly be converting back and forth between BYTE and DOUBLE or INT.
  - In this case, it might make more sense to choose int if you don't need subsecond precision, and double if you do need subsecond precision.
*/

/* 
Choose data types based on impact to other systems
  - Sometimes, you must consider how the information will be consumed by other applications or other systems like a database.
  - For example, SQL Server's type system is different from C#'s type system.
  - As a result, some mapping between the two must happen before you can save data into that database.
  - If your application's purpose is to interface with a database, then you would likely need to consider how the data is stored and how much data is stored.
  - The choice of a larger data type might impact the amount (and cost) of the physical storage required to store all the data your application will generate.
*/
