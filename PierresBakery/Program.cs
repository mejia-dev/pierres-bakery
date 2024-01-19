using System;
using System.Threading;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("@-------------------------@");
      PickItem(0, 0);
    }

    static void PickItem(int pastriesCount = 0, int breadCount = 0)
    {
      Console.WriteLine("CART: --- {0} pastries and {1} loaves", pastriesCount, breadCount);
      Console.WriteLine("Would you like to buy pastries or bread?");
      string input = Console.ReadLine();

      if (input.ToLower().Contains("pastr"))
      {
        Console.WriteLine("");
        Console.WriteLine("Each pastry costs $2. Buy 3 pastries, get the 4th one free!");
        Console.WriteLine("You currently have {0} pastries in your cart.", breadCount);
        BuyItem(pastriesCount, breadCount, "pastries");
      }
      else if (input.ToLower().Contains("bread") || input.ToLower().Contains("loa"))
      {
        Console.WriteLine("");
        Console.WriteLine("Each loaf of bread costs $5. Buy 2 loaves, get the 3rd one free!");
        Console.WriteLine("You currently have {0} loaves in your cart.", breadCount);
        BuyItem(pastriesCount, breadCount, "loaves");

      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("We unfortunately don't sell {0}.", input);
        PickItem(pastriesCount, breadCount);
      }
    }

    static void BuyItem(int pastriesCount, int breadCount, string wordForMultiple)
    {
      Console.WriteLine("Enter the new total number of {0} you want to buy, or enter any other character to return to the previous screen: ", wordForMultiple);
      if (int.TryParse(Console.ReadLine(), out int inputtedAmount))
      {
        Console.WriteLine("You now have {0} {1} in your cart. Would you like to checkout or keep shopping?", inputtedAmount, wordForMultiple);
        Console.WriteLine("(enter 'checkout' to checkout or any other key to keep shopping)");
        string navInput = Console.ReadLine();
        if (navInput.ToLower().Contains("check"))
        {
          if (wordForMultiple == "loaves")
          {
            CheckoutMenu(pastriesCount, inputtedAmount);
          }
          else
          {
            CheckoutMenu(inputtedAmount, breadCount);
          }
        }
        else
        {
          if (wordForMultiple == "loaves")
          {
            Console.WriteLine("");
            PickItem(pastriesCount, inputtedAmount);
          }
          else
          {
            Console.WriteLine("");
            PickItem(inputtedAmount, breadCount);
          }
        }

      }
      else
      {
        Console.WriteLine("");
        PickItem(pastriesCount, breadCount);
      }
    }

    static void CheckoutMenu(int pastriesCount, int breadCount)
    {
      Console.WriteLine("You currently have {0} pastries and {1} loaves in your cart.", pastriesCount, breadCount);
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.Write("Calculating your total");
      int costOfPastries = Pastry.GetBasketTotal(pastriesCount);
      int costOfBread = Bread.GetBasketTotal(breadCount);
      Thread.Sleep(700);
      Console.Write(".");
      Thread.Sleep(700);
      Console.Write(".");
      Thread.Sleep(700);
      Console.Write(".");
      Console.WriteLine("");
      Console.WriteLine("Your total is ${0}. Thank you for shopping with us!", costOfBread + costOfPastries);
      Thread.Sleep(700);
    }

    // static void BuyPastry(int pastriesCount, int breadCount)
    // {
    //   Console.WriteLine("Each pastry costs $2. Buy 3 pastries, get the 4th one free!");

    // }

  }
}


// Console.WriteLine("Enter the number of loaves you want to buy (enter 0 to exit): ");
// if (int.TryParse(Console.ReadLine(), out int loaves))
// {
//   if (loaves == 0)
//   {
//     Console.WriteLine("Thank you for shopping at Pierre's Bakery. Goodbye!");
//     break;
//   }

//   int totalCost = Bread.GetBasketTotal(loaves);

//   Console.WriteLine($"Total cost for {loaves} loaves: ${totalCost}");
//   Console.WriteLine();
// }
// else
// {

// }