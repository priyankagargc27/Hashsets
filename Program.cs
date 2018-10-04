using System;
using System.Collections.Generic;
using System.Linq;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
HashSet<string> showroom = new HashSet<string>();
showroom.Add("Lexus-rx350");
showroom.Add("BMW-530");
showroom.Add("Porche");
showroom.Add("Highlander");
showroom.Add("Highlander");
Console.WriteLine("There are {0} cars in the showroom",showroom.Count);
foreach (string vehicle in showroom)
{
    Console.WriteLine($"{vehicle}");
}
HashSet<string> usedLot = new HashSet<string>();
 usedLot.Add("Tesla");
 usedLot.Add("Volvo");
  Console.WriteLine("usedLot unionwith showrrom");
        showroom.UnionWith(usedLot);
      showroom.Remove("Highlander"); 
        foreach (string vehicle in showroom)
{
    Console.WriteLine($"{vehicle}");
}




        }
    }
}
