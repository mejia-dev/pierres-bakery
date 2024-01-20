using System;
using System.Threading;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine(@"
                W e l c o m e   t o
      @-------------------------------------@
      ╔═╗┬┌─┐┬─┐┬─┐┌─┐┌─┐  ╔╗ ┌─┐┬┌─┌─┐┬─┐┬ ┬
      ╠═╝│├┤ ├┬┘├┬┘├┤ └─┐  ╠╩╗├─┤├┴┐├┤ ├┬┘└┬┘
      ╩  ┴└─┘┴└─┴└─└─┘└─┘  ╚═╝┴ ┴┴ ┴└─┘┴└─ ┴ 
      @-------------------------------------@
      ");
      Console.ResetColor();
      PickItem();
    }

    static void PickItem(int pastriesCount = 0, int breadCount = 0)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("CART: --- {0} pastries and {1} loaves", pastriesCount, breadCount);
      Console.ResetColor();
      Console.WriteLine("Would you like to buy pastries or bread?");
      if (pastriesCount > 0 || breadCount > 0 )
      {
        Console.Write("Enter '");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("checkout");
        Console.ResetColor();
        Console.Write("' to checkout at any time.");
      }
      string input = Console.ReadLine();

      if (input.ToLower().Contains("pastr"))
      {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
                                                                                        
                                                                                        
                                                                                        
                                                                                        
                                                                                        
                                              ██████                                    
                                  ████████████░░░░░░██                                  
                                ██░░░░░░░░░░░░██░░░░░░██████                            
                              ██░░░░░░░░░░░░░░██░░░░░░██░░░░██                          
                            ██░░░░░░░░░░░░░░░░░░██░░░░██░░░░░░██                        
                            ██░░░░░░░░░░░░░░░░░░░░██░░██░░░░░░██                        
                            ██░░░░░░░░░░░░░░░░░░░░██░░████████                          
                          ██░░████░░░░░░░░░░░░░░░░██░░██                                
                          ██░░░░░░████░░░░░░░░░░░░████                                  
                        ██░░░░░░░░░░░░████░░░░░░░░██                                    
                        ██░░░░░░░░░░░░░░░░██░░░░██                                      
                          ██░░░░░░░░░░░░░░██████                                        
                        ██░░████████░░░░░░██                                            
                        ██░░░░░░░░░░██████                                              
                          ██░░░░░░░░░░██                                                
                        ██░░██████████                                                  
                        ██░░░░░░░░██                                                    
                          ██░░░░██                                                      
                            ████                                                        
                                                                                      
");
        Console.ResetColor();
        Console.WriteLine("Each pastry costs $2. Buy 3 pastries, get the 4th one free!");
        Console.WriteLine("You currently have {0} pastries in your cart.", pastriesCount);
        BuyItem(pastriesCount, breadCount, "pastries");
      }
      else if (input.ToLower().Contains("bread") || input.ToLower().Contains("loa"))
      {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"                                                                                        
                                                                                        
                                                                                        
                                                                                        
                                                                                        
                                                                                        
                                      ░░                                                
                                                ██████████████                          
                                        ████████▓▓▓▓██░░░░██▓▓████                      
                                ████████░░░░░░░░██▓▓██░░░░██▓▓▓▓▓▓██                    
                            ████░░██▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██                  
                        ████░░░░░░░░██▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██                  
                      ██▓▓▓▓██░░░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██                      
                    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                        
                    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                            
                      ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                                
                          ████████▓▓▓▓▓▓▓▓▓▓▓▓██████                                    
                                  ████████████                                          
                                                                                                                                                     
        ");
        Console.ResetColor();
        Console.WriteLine("Each loaf of bread costs $5. Buy 2 loaves, get the 3rd one free!");
        Console.WriteLine("You currently have {0} loaves in your cart.", breadCount);
        BuyItem(pastriesCount, breadCount, "loaves");

      }
      else if (input.ToLower().Contains("check") && (pastriesCount > 0 || breadCount > 0 ))
      {
        Console.WriteLine("");
        CheckoutMenu(pastriesCount, breadCount);
      }
      else
      {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("We unfortunately don't sell {0}.", input);
        Console.ResetColor();
        Thread.Sleep(700);
        PickItem(pastriesCount, breadCount);
      }
    }

    static void BuyItem(int pastriesCount, int breadCount, string wordForMultiple)
    {
      Console.WriteLine("Enter the new total number of {0} you want to buy, or enter any other character to return to the previous screen: ", wordForMultiple);
      if (int.TryParse(Console.ReadLine(), out int inputtedAmount))
      {
        Console.WriteLine("");
        Console.Write("You now have ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("{0} {1}",inputtedAmount, wordForMultiple);
        Console.ResetColor();
        Console.Write(" in your cart. Would you like to checkout or keep shopping?");
        Console.WriteLine("");
        Console.WriteLine("(enter 'checkout' to checkout or any other key to keep shopping)");
        string navInput = Console.ReadLine();
        if (navInput.ToLower().Contains("check"))
        {
          if (wordForMultiple == "loaves")
          {
            Console.WriteLine("");
            CheckoutMenu(pastriesCount, inputtedAmount);
          }
          else
          {
            Console.WriteLine("");
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
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(@"
       ______________________________________________________________________
      |.============[_F_E_D_E_R_A_L___R_E_S_E_R_V_E___N_O_T_E_]=============.|
      ||%&%&%&%_    _        _ _ _   _ _  _ _ _     _       _    _  %&%&%&%&||
      ||%&.-.&/||_||_ | ||\||||_| \ (_ ||\||_(_  /\|_ |\|V||_|)|/ |\ %&.-.&&||
      ||&// |\ || ||_ \_/| ||||_|_/ ,_)|||||_,_) \/|  ||| ||_|\|\_|| &// |\%||
      ||| | | |%               ,-----,-'____'-,-----,               %| | | |||
      ||| | | |&% ''''''''''  [    .-;'`___ `';-.    ]             &%| | | |||
      ||&\===//                `).'' .'`_.- `. '.'.(`  A 76355942 J  \\===/&||
      ||&%'-'%/1                // .' /`     \    \\                  \%'-'%||
      ||%&%&%/`   d8888b       // /   \  _  _;,    \\      .-'''-.  1 `&%&%%||
      ||&%&%&    8P |) Yb     ;; (     > a  a| \    ;;    //A`Y A\\    &%&%&||
      ||&%&%|    8b |) d8     || (    ,\   \ |  )   ||    ||.-'-.||    |%&%&||
      ||%&%&|     Y8888P      ||  '--'/`  -- /-'    ||    \\_/~\_//    |&%&%||
      ||%&%&|                 ||     |\`-.__/       ||     '-...-'     |&%&%||
      ||%%%%|                 ||    /` |._ .|-.     ||                 |%&%&||
      ||%&%&|  A 76355942 J  /;\ _.'   \  } \  '-.  /;\                |%&%&||
      ||&%.-;               (,  '.      \  } `\   \'  ,)   ,.,.,.,.,   ;-.%&||
      ||%( | ) 1  '''''''   _( \  ;...---------.;.; / )_ ```''''''' 1 ( | )%||
      ||&%'-'==================\`------------------`/=================='-'%&||
      ||%&JGS&%&%&%&%%&%&&&%&%%&)O N E  D O L L A R(%&%&%&%&%&%&%%&%&&&%&%%&||
      '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''`

      ");
      Console.ResetColor();
      Console.WriteLine("You currently have {0} pastries and {1} loaves in your cart.", pastriesCount, breadCount);
      Thread.Sleep(700);
      if (pastriesCount > 3 )
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You ordered more than three pastries! Every fourth pastry is free!");
        Console.ResetColor();
      }
      if (breadCount > 2 )
      {
        Thread.Sleep(700);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("You ordered more than two loaves of bread! Every third loaf is free!");
        Console.ResetColor();
      }
      
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.Write("Calculating your total");
      int costOfPastries = Pastry.GetBasketTotal(pastriesCount);
      int costOfBread = Bread.GetBasketTotal(breadCount);
      Thread.Sleep(500);
      Console.Write(".");
      Thread.Sleep(500);
      Console.Write(".");
      Thread.Sleep(500);
      Console.Write(".");
      Console.WriteLine("");

      Console.Write("Your total is ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("${0}",costOfBread + costOfPastries);
      Console.ResetColor();
      Console.Write(". Thank you for shopping with us!");

      Thread.Sleep(700);
    }
  }
}