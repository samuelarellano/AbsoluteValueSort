// See https://aka.ms/new-console-template for more information

using AbsoluteValueSort.Utils;

int[] arr = { 2, -7, -2, -2, 0 };
Operations operations = new();
int[] result = operations.AbsSort(arr);

Console.WriteLine(string.Join(", ", result)); // Output: 0, -2, -2, 2, -7