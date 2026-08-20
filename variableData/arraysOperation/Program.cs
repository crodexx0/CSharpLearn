/*
  This code demonstrates basic array operations in C#:
  1. Declares and initializes an array of string values representing pallet IDs.
  2. Uses the static Array.Sort method to sort the pallet IDs in alphabetical order.
  3. Iterates through the sorted array using a foreach loop and prints each pallet ID to the console prefixed with double dashes.
*/
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

