using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Get numbers from the user
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Find the sum
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        // Find the average
        double average = (double)sum / numbers.Count;

        // Find the largest number
        int largest = numbers[0];

        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}