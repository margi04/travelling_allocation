using System;
using System.Collections.Generic;

class travelling_allocation

{
    static void Main(string[] args)
    {
        string[] tripdays = { "Day1", "Day2", "Day3", "Day4" };

        List<string> destinations = new List<string>()
    {
        "Mathura",
        "Vrundavan"
    };

        Dictionary<string, List<string>> placestovisit = new Dictionary<string, List<string>>()
    {
        {"Mathura", new List<string>(){"Krishna Janmabhoomi", "Dwarkadhish Temple", "Vishram Ghat"} },
        {"Vrundavan", new List<string>(){"Banke Bihari Temple", "ISKCON Temple", "Prem Mandir"} }
    };

        Console.WriteLine("Travel Itinerary:\n");

        int dayindex = 0;
        foreach(var day in tripdays)
        {
            if (day == "Day1")
            {
                Console.WriteLine($"{day}: Travel/Arrival and Check in");
            }
            else if(day == "Day4")
            {
                Console.WriteLine($"{day}: Check out and Departure");
            }
            else
            {
                string destination = destinations[dayindex % destinations.Count];
                Console.WriteLine($"{day}: Visit {destination}");
                Console.WriteLine("Places to visit:");
                foreach (var place in placestovisit[destination])
                {
                    Console.WriteLine($" - {place}");
                }
                dayindex++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Enjoy your trip!");

    }
}
