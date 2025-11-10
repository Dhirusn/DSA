// See https://aka.ms/new-console-template for more information
using Linear_Search;

class Program
{
    static void Main(string[] args)
    {
        //Linear Search
        int[] numbers = { 5, 2, 8, 1, 9, 3, 7, 4 };
        int lookingFor = 1;
        int spot = LinearSearchExample.Search(numbers, lookingFor);

        if (spot != -1)
        {
            Console.WriteLine($"Yay! {lookingFor} is chilling at index {spot} (that's position {spot + 1} for us non-coders).");
        }
        else
        {
            Console.WriteLine($"'{lookingFor}'? Haven't seen it around here.");
        }

        //Binary Search
        int[] sortedNumbers = { 1, 2, 4, 5, 7, 8, 9, 10 };  // Gotta be sorted!
        int target = 2;
        int foundAt = BinarySearchExample.Search(sortedNumbers, target);

        if (foundAt != -1)
        {
            Console.WriteLine($"Score! {target} is at index {foundAt} (position {foundAt + 1}). Binary high-five!");
        }
        else
        {
            Console.WriteLine($"'{target}'? Slipped through the cracks.");
        }
    }

}
