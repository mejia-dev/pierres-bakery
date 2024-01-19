using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Each loaf of bread costs $5. Buy 2 loaves, get the 3rd one free!");

      while (true)
      {
        Console.Write("Enter the number of loaves you want to buy (enter 0 to exit): ");
        if (int.TryParse(Console.ReadLine(), out int loaves))
        {
          if (loaves == 0)
          {
            Console.WriteLine("Thank you for shopping at Pierre's Bakery. Goodbye!");
            break;
          }

          int totalCost = Bread.GetBasketTotal(loaves);

          Console.WriteLine($"Total cost for {loaves} loaves: ${totalCost}");
          Console.WriteLine();
        }
        else
        {
          Console.WriteLine("Invalid input. Please enter a valid number.");
        }
      }
    }
  }
}
