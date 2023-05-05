using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int total = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.Write($"The total is {numbers}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}       
