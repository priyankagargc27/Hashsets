using System;
using System.Collections.Generic;
using System.Linq;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise for Hashsets
HashSet<string> showroom = new HashSet<string>();
showroom.Add("Lexus-rx350");
showroom.Add("BMW-530");
showroom.Add("Porche");
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

// Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached
//  you about buying the entire inventory. In the new set, add some different cars,
//   but also add a few that are the same as in the Showroom set.

 HashSet<string> Junkyard = new HashSet<string>()
            {
                ("Leaf"),
                ("corrola"),
                ("Lexus-rx350"),
                ("Dodge"),
                ("Highlander"),
                ("civic"),
                ("Porche"),

            };

            // Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);

            HashSet<string> clone = new HashSet<string>(showroom);
            // Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.

                        clone.IntersectWith(Junkyard);

    Console.WriteLine("Cars available in the Junkyard and the showroom");
foreach (string vehicle in clone)
{
    Console.WriteLine($"{vehicle}");
}

// Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.

        showroom.UnionWith(Junkyard);
        // Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.

        showroom.Remove("civic");
        Console.WriteLine("Total cars of my showroom now:");
         foreach (string vehicle in showroom)
{
    Console.WriteLine($"{vehicle}");
}
        }
    }
}
