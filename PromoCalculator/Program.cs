using PromoCalculator.Helper;
using PromoCalculator.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PromoCalculator
{
  class Program
  {
    /// <summary>
    /// The Promotion.
    /// </summary>
    /// <param name="skuItems">The skuItems<see cref="List{UnitItem}"/>.</param>
    /// <returns>The <see cref="int"/>.</returns>
    public delegate int Promotion(List<UnitItem> skuItems);

    /// <summary>
    /// Defines the SkuItemsTable.
    /// </summary>
    internal static readonly Hashtable SkuItemsTable = new();

    /// <summary>
    /// The Main.
    /// </summary>
    /// <param name="args">The args<see cref="string[]"/>.</param>
    internal static void Main(string[] args)
    {
      try
      {
        string tryAgain = "Y";
        PromoSelector.DisplayAvailableUnitItems();
        while (tryAgain.Trim().ToUpper().Equals("Y"))
        {
        start:
          List<UnitItem> skuItemsList = PromoSelector.SelectUnitItems(SkuItemsTable);
          if (skuItemsList.Count > 0)
          {

            // Apply Selected promotion : One Promotion applicable at one time                                


            // Display Cart Final Value
            Console.WriteLine("Final Value");
            
            Console.ReadKey();
          }
          else
          {
            Console.WriteLine("Invalid inputs. Lets' try again..");
            goto start;
          }
          Console.WriteLine("Try Again (y/n)?");
          tryAgain = Console.ReadLine();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Oops!! encountered error:- {ex.Message}./n Please try again..exiting....");
      }
    }
  }
}
