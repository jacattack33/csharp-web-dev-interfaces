using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            FlavorComparer comparer = new FlavorComparer();

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            availableFlavors.Sort(comparer);

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            availableCones.Sort(new ConeComparer());
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].Name + ": " + availableCones[i].Cost);
            }
            for (int i = 0; i < availableFlavors.Count; i++)
            {
                Console.WriteLine(availableFlavors[i].Name + ": " + availableFlavors[i].Cost);
            }


        }
    }
}
