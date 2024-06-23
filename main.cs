using System;
using System.Linq;
// Now, modify the program to use arrays to store the salesperson names, allowed initials, and accumulated sales values.
class Program
{
  public static void Main(string[] args)
  {
    var allowedInitials = new char[] { 'd', 'e', 'f' };
    var salesPeople = new char[3];
    var accumulatedSales = new int[3];


    Console.Write("salesperson: ");
    var salesperson = Convert.ToChar(Console.ReadLine().ToLower());
    var highestSale = 0;
    var highest = ' ';
    var grandTotal = 0;

    while (salesperson != 'z')
    {
      var isAllowed = false;
      foreach (var allowedInitial in allowedInitials)
      {

        if (salesperson == allowedInitial)
        {
          isAllowed = true;
          Console.Write("sale: ");
          var sale = Convert.ToInt32(Console.ReadLine());
          grandTotal += sale;
          if (sale > highestSale)
          {
            highest = salesperson;
            highestSale = sale;
          }
        }
      }
      if (!isAllowed)
      {
        Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
        
      }

      Console.Write("salesperson: ");
      salesperson = Convert.ToChar(Console.ReadLine().ToLower());
    }


    Console.WriteLine("Grand Total: {0:C0}", grandTotal);
    Console.WriteLine("Highest Sale: {0}", Char.ToUpper(highest));
    Console.WriteLine("Passed");
  }
}