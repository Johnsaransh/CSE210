using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Park Ave", "Chicago", "IL", "USA");
        Address address3 = new Address("789 Beach Blvd", "Miami", "FL", "USA");

        Lecture lecture = new Lecture("Tech Talk", "Learn about AI", "May 1, 2025", "6:00 PM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Night", "Meet new people", "June 10, 2025", "7:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Fest", "Outdoor fun event", "July 15, 2025", "3:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine("\n---------------------------\n");
        }
    }
}