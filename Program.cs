using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Input your scores");

        
        string input = Console.ReadLine();

        // Convert the string array into an array of integers
        int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

        var sum = 0;

        // Process each number in the array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += 1; // If the number is even, add 1
            }
            else if (numbers[i] % 2 == 1)
            {
                sum += 3; // If the number is odd, add 3
            }

            // Check if the number is equal to 8
            if (numbers[i] == 8)
            {
                sum += 5; // If the number is 8, add 5
            }
        }

        // Print the result
        Console.WriteLine("The sum is: " + sum);
    }
}
