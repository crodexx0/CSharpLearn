/*
  This code demonstrates basic array operations in C#:
  1. Declares and initializes an array of string values representing pallet IDs.
  2. Uses the static Array.Sort method to sort the pallet IDs in alphabetical order.
  3. Iterates through the sorted array using a foreach loop and prints each pallet ID to the console prefixed with double dashes.

  Expected Output:
  Sorted...
  -- A11
  -- A13
  -- B12
  -- B14
*/
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


/*
  This code group demonstrates sorting and reversing an array:
  1. Declares and initializes an array of pallet IDs (`palletsSecond`).
  2. Uses Array.Sort to sort the array in alphabetical order and prints the results.
  3. Uses Array.Reverse to reverse the sorted array elements, resulting in descending alphabetical order, and prints them.

  Expected Output:
  Sorted...
  -- A11
  -- A13
  -- B12
  -- B14

  Reversed...
  -- B14
  -- B12
  -- A13
  -- A11
*/
string[] palletsSecond = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(palletsSecond);
foreach (var pallet in palletsSecond)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(palletsSecond);
foreach (var pallet in palletsSecond)
{
    Console.WriteLine($"-- {pallet}");
}


/*
  This code group demonstrates clearing elements in an array:
  1. Declares and initializes an array of pallet IDs (`palletsThird`).
  2. Prints the value of the first element before calling Array.Clear.
  3. Uses Array.Clear to clear 2 elements starting at index 0. This replaces string elements with null (their default value).
  4. Prints the first element after clearing (which displays nothing because it is null).
  5. Displays the total number of elements (which remains unchanged at 4 because Array.Clear does not resize the array).
  6. Iterates and prints each element, where the cleared elements (null elements) appear as empty lines.

  Expected Output:
  Before: B14
  After: 
  Clearing 2 ... count: 4
  -- 
  -- 
  -- B12
  -- A13
*/

string[] palletsThird = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {palletsThird[0]}");
Array.Clear(palletsThird, 0, 2);
Console.WriteLine($"After: {palletsThird[0]}");

Console.WriteLine($"Clearing 2 ... count: {palletsThird.Length}");
foreach (var pallet in palletsThird)
{
    Console.WriteLine($"-- {pallet}");
}

/*
  This code group demonstrates resizing an array:
  1. Declares and initializes an array of pallet IDs (`palletsThird`).
  2. Prints the value of the first element before calling Array.Resize.
  3. Uses Array.Resize to resize the array to 6 elements.
  4. Prints the first element after resizing (which displays nothing because it is null).
  5. Displays the total number of elements (which is now 6 because Array.Resize resized the array).
  6. Iterates and prints each element, where the resized elements (null elements) appear as empty lines.

  Expected Output:
  Resizing 6 ... count: 6
  -- 
  -- 
  -- B12
  -- A13
  -- C01
  -- C02
*/

Console.WriteLine("");
Array.Resize(ref palletsThird, 6);
Console.WriteLine($"Resizing 6 ... count: {palletsThird.Length}");

palletsThird[4] = "C01";
palletsThird[5] = "C02";

foreach (var pallet in palletsThird)
{
    Console.WriteLine($"-- {pallet}");
}

/*
  This code group demonstrates using Array.Resize() to remove elements from an array:
  1. Declares and initializes an array of pallet IDs (`pallets`).
  2. Prints the value of the first element before calling Array.Resize.
  3. Uses Array.Resize to resize the array to 3 elements.
  4. Prints the first element after resizing (which displays nothing because it is null).
  5. Displays the total number of elements (which is now 3 because Array.Resize resized the array).
  6. Iterates and prints each element, where the resized elements (null elements) appear as empty lines.

  Expected Output:
  Resizing 3 ... count: 3
  -- A11
  -- A13
  -- B12
*/

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*
  This code group demonstrates using ToCharArray and Array.Reverse to reverse a string:
  1. Declares and initializes a string value.
  2. Converts the string to a character array using ToCharArray.
  3. Reverses the order of the characters in the array using Array.Reverse.
  4. Converts the reversed character array back to a string and prints it.

  Expected Output:
  321cba
  3,2,1,c,b,a
*/

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
// Combines the characters in the array into a string separated by commas
string result2 = String.Join(",", valueArray);
Console.WriteLine(result2);

/*
  This code group demonstrates splitting a string into an array of substrings:
  1. Uses the String.Split method on `result2` to split the comma-separated string back into an array of individual character substrings.
  2. Iterates through the resulting string array using a foreach loop and prints each substring on a new line.

  Expected Output:
  3
  2
  1
  c
  b
  a
*/

string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}



/*
  This code group demonstrates a challenge to reverse each word of a sentence individually while keeping the word order the same:
  1. Splitting the sentence into an array of words using space as a separator.
  2. Declaring a new array of strings to hold the reversed words.
  3. Iterating through each word, converting it to a character array, reversing the characters, and creating a new string representing the reversed word.
  4. Joining the reversed words back with space separators and printing the result.

  Expected Output:
  ehT kciuq nworb xof spmuj revo eht yzal god
*/
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramWords = pangram.Split(' ');
string[] reversedPangramWords = new string[pangramWords.Length];

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] reversedWord = pangramWords[i].ToCharArray();
    Array.Reverse(reversedWord);
    reversedPangramWords[i] += new String(reversedWord);
}
Console.WriteLine(String.Join(" ", reversedPangramWords));



/*
  This code group demonstrates parsing, sorting, and tagging errors in a comma-separated stream of order IDs:
  1. Splitting the comma-separated string of order IDs into an array using String.Split.
  2. Sorting the array of order IDs alphabetically using Array.Sort.
  3. Iterating through the sorted array and checking if each order ID has a length of exactly 4.
  4. Printing the order ID, and if it does not have a length of 4, appending a "\t- Error" tag.

  Expected Output:
  A345
  B123
  B177
  B179
  C15	- Error
  C234
  C235
  G3003	- Error
*/
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);
foreach (string order in orders)
{
    // if (order.Length != 4)
    // {
    //     Console.WriteLine($"{order}\t- Error");
    // }
    // else
    // {
    //     Console.WriteLine($"{order}");
    // }
    Console.WriteLine($"{order}{(order.Length != 4 ? "\t- Error" : "")}");
}
