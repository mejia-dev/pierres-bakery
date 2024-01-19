using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      PickItem(0, 0);
    }

    static void PickItem(int pastriesCount = 0, int breadCount = 0)
    {
      Console.Write("Would you like to buy pastries or bread?");
      string input = Console.ReadLine();

      if (input.ToLower().Contains("pastr"))
      {
        // BuyPastry(pastriesCount, breadCount);
      }
      else if (input.ToLower().Contains("bread") || input.ToLower().Contains("loa"))
      {
        Console.WriteLine("Each loaf of bread costs $5. Buy 2 loaves, get the 3rd one free!");
        Console.WriteLine("You currently have {0} loaves in your cart",breadCount);
        BuyBread(pastriesCount, breadCount);
        
      }
      else
      {
        Console.WriteLine("We unfortunately don't sell {0}.", input);
        PickItem(pastriesCount, breadCount);
      }
    }

    static void BuyBread(int pastriesCount, int breadCount)
    {
      
      Console.Write("Enter the new total number of loaves you want to buy, or enter any other character to return to the previous screen: ")
      if (int.TryParse(Console.ReadLine(), out int inputtedAmount))
      {
        Console.WriteLine("You now have {0} loaves in your cart. Would you like to checkout or keep shopping?", inputtedAmount);
        Console.WriteLine("(enter 'checkout' to checkout or any other key to keep shopping)");
        string navInput = Console.ReadLine();
        if (navInput.ToLower.Contains("check"))
        {

        }
        else
        {
          PickItem(pastriesCount, inputtedAmount);  
        }

      }
      else
      {
        PickItem(pastriesCount, breadCount);
      }
    }

    // static void BuyPastry(int pastriesCount, int breadCount)
    // {
    //   Console.WriteLine("Each pastry costs $2. Buy 3 pastries, get the 4th one free!");

    // }

  }
}


// Console.Write("Enter the number of loaves you want to buy (enter 0 to exit): ");
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
          
        }