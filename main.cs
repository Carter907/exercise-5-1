using System;

class Program {
  public static void Main(string[] args) {
    Console.Write("salesperson: ");
    var salesperson = Console.ReadLine().ToLower();
    var highestSale = 0;
    var highest = "";
    var grandTotal = 0;
    while (salesperson != "z") {
      switch (salesperson) {
        case "d":
        case "e":
        case "f":
          Console.Write("sale: ");
          var sale = Convert.ToInt32(Console.ReadLine());
          grandTotal+=sale;
          if (sale > highestSale) {
            highest = salesperson;
            highestSale = sale;
          }

          break;
          default:
          Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
            break;
      }
      Console.Write("salesperson: ");
      salesperson = Console.ReadLine().ToLower();
    }
    Console.WriteLine("Grand Total: {0:C0}", grandTotal);
    Console.WriteLine("Highest Sale: {0}", highest.ToUpper());
    Console.WriteLine("Passed");
  }
}