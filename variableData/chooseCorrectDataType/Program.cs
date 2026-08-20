// ==========================================
// C# DATA TYPES & MEMORY MANAGEMENT GUIDE
// ==========================================
// This program demonstrates the properties of various C# data types,
// explains Value Types vs. Reference Types, and illustrates Stack vs. Heap memory allocation.

// ------------------------------------------
// SECTION 1: INTEGRAL TYPES (INTEGERS)
// ------------------------------------------

Console.WriteLine("==================================================");
Console.WriteLine("SIGNED INTEGRAL TYPES");
Console.WriteLine("==================================================");
// Signed integral types can represent both positive and negative values.
// They use the most significant bit (MSB) as a sign bit, which halves the maximum positive range
// compared to their unsigned counterparts of the same bit-width.

// sbyte: 8-bit signed integer (Range: -128 to 127)
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");

// short: 16-bit signed integer (Range: -32,768 to 32,767)
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");

// int: 32-bit signed integer (Range: -2,147,483,648 to 2,147,483,647) - The default integer type in C#
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");

// long: 64-bit signed integer (Range: ~-9 Quintillion to ~9 Quintillion)
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine();

Console.WriteLine("==================================================");
Console.WriteLine("UNSIGNED INTEGRAL TYPES");
Console.WriteLine("==================================================");
// Unsigned integral types can only represent non-negative values (0 and positive numbers).
// Since no bit is reserved for the sign (+/-), the entire bit-width is used for the value,
// doubling the positive upper limit compared to the corresponding signed type.

// byte: 8-bit unsigned integer (Range: 0 to 255)
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");

// ushort: 16-bit unsigned integer (Range: 0 to 65,535)
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");

// uint: 32-bit unsigned integer (Range: 0 to 4,294,967,295)
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");

// ulong: 64-bit unsigned integer (Range: 0 to ~18 Quintillion)
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine();

// ------------------------------------------
// SECTION 2: FLOATING POINT TYPES (DECIMALS)
// ------------------------------------------

Console.WriteLine("==================================================");
Console.WriteLine("FLOATING POINT TYPES");
Console.WriteLine("==================================================");
// Floating point types represent numbers with fractional components. 
// They differ in precision (number of significant digits they can accurately hold) and storage size.

// float: 32-bit single-precision floating point. Best for graphics, physics, or game engines where speed is prioritized over extreme precision.
// Has ~6-9 digits of precision. Uses the 'f' suffix in literals (e.g., 3.14f).
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");

// double: 64-bit double-precision floating point. The default literal type for fractional numbers.
// Has ~15-17 digits of precision. Best for general-purpose scientific calculations.
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");

// decimal: 128-bit decimal floating point. High-precision financial and monetary calculations.
// Has 28-29 digits of precision. Virtually eliminates rounding errors common in float/double.
// Uses the 'm' suffix in literals (e.g., 99.99m).
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

Console.WriteLine();

// NOTE ON SCIENTIFIC NOTATION (E NOTATION):
// "E notation" stands for "times 10 raised to the power of."
// For example: 5E+2 means 5 * 10^2 = 5 * 100 = 500.
// Similarly, -3.4E+38 means -3.4 * 10^38.

// ------------------------------------------
// SECTION 3: VALUE TYPES & STACK MEMORY
// ------------------------------------------

Console.WriteLine("==================================================");
Console.WriteLine("VALUE TYPES AND THE STACK");
Console.WriteLine("==================================================");
// Value types store their values directly in an area of high-speed memory called the STACK.
// The stack is allocated for the current thread/method execution frame (activation record).
// When the execution goes out of scope (e.g., method exits), stack memory is automatically and instantly reclaimed.

// Let's demonstrate Value Type copy behavior:
int val_A = 2;       // Allocates space on the stack for val_A and stores '2'
int val_B = val_A;   // Allocates space on the stack for val_B and COPIES the value of val_A ('2') into it
val_B = 5;           // Changes the value inside val_B's stack allocation to '5'

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A (Expected: 2): {val_A}");
Console.WriteLine($"val_B (Expected: 5): {val_B}");
// EXPLANATION: Since val_B holds an independent copy, modifying val_B has absolutely no effect on val_A.

Console.WriteLine();

// ------------------------------------------
// SECTION 4: REFERENCE TYPES & HEAP MEMORY
// ------------------------------------------

Console.WriteLine("==================================================");
Console.WriteLine("REFERENCE TYPES AND THE HEAP");
Console.WriteLine("==================================================");
// Reference types store a memory address (a reference) on the stack, which points to the actual data stored in the HEAP.
// The heap is a larger, shared pool of memory managed by the .NET Garbage Collector (GC).
// Heap access is slightly slower than stack access because of the indirection (pointer lookup).

// 1. Array Example:
int[] data; // Declares a reference variable on the STACK. At this point, it is 'null' (doesn't point to any address yet).

data = new int[3]; 
// The 'new' keyword requests the .NET Runtime to allocate memory on the HEAP for an array of 3 integers.
// The runtime allocates the memory and returns its starting address.
// This memory address is then stored in the 'data' variable on the stack.

// 2. String Example:
string shortenedString = "Hello World!";
Console.WriteLine($"shortenedString: {shortenedString}");
// Strings are reference types, but we didn't use the 'new' keyword here.
// This is a language design convenience (syntactic sugar) in C#.
// Under the hood, the C# compiler allocates a System.String object on the heap and points 'shortenedString' to it.

// 3. Demonstrating Reference Type copy behavior:
int[] ref_A = new int[1]; // Allocates a 1-element int array on the heap; ref_A stores its memory address
ref_A[0] = 2;             // Stores '2' at the heap address pointed to by ref_A

int[] ref_B = ref_A;      // COPIES the memory address (reference) from ref_A to ref_B. Both variables now point to the EXACT same heap address!
ref_B[0] = 5;             // Changes the value at that shared heap address to '5'

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0] (Expected: 5): {ref_A[0]}");
Console.WriteLine($"ref_B[0] (Expected: 5): {ref_B[0]}");
// EXPLANATION: Because ref_A and ref_B reference the same heap location, altering the heap data through ref_B affects ref_A as well.

Console.WriteLine();

// ------------------------------------------
// SECTION 5: HOW TO CHOOSE THE RIGHT DATA TYPE
// ------------------------------------------

/* 
GUIDELINE A: Choose by Range and Storage Efficiency
Suppose your variable only needs to store integer values between 1 and 10,000:
  - Avoid byte/sbyte: Their maximum capacities (255/127) are too low.
  - Avoid int, long, uint, ulong: They are 32-bit or 64-bit and allocate far more memory than necessary (oversized).
  - Avoid float, double, decimal: These represent fractions and introduce unnecessary floating-point CPU overhead.
  - Choose short or ushort (16-bit): Both cover 10,000. If negative values are logically impossible/invalid,
    choose ushort (0 to 65,535). Assigning an out-of-range value will trigger an exception, acting as an implicit validation guard!

GUIDELINE B: Choose by System Interoperability
Suppose you are tracking years (e.g., 1960 to 2200):
  - Structurally, 'byte' can't fit 1960+, but 'short' or 'ushort' fits easily.
  - However, standard library classes like TimeSpan and DateTime primarily accept 'int' or 'double' arguments in their methods.
  - If you choose 'short', you will constantly have to cast (convert) values back and forth, cluttering code and hurting performance.
  - In this scenario, choosing 'int' is best for clean integration, and 'double' if you need sub-second precision.

GUIDELINE C: Choose by Physical Database/API Constraints
When persisting data to a storage medium or communicating over a network (e.g., JSON, SQL database, cloud API):
  - Consider the target system's datatype mapping. SQL Server's types differ from C#'s.
  - Unnecessarily large datatypes (like using ulong/long when short would suffice) scale poorly.
  - Across millions of database rows, selecting an optimized data type can save gigabytes of physical storage, improve index search performance, and reduce cloud infrastructure costs.
*/
