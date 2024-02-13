using System;

namespace AirlineReservationSystem
{
    // Abstract class representing a flight
    public abstract class Flight
    {
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        // Abstract method for booking a seat
        public abstract void BookSeat();
    }

    // Concrete class representing an Economy class flight
    public class EconomyFlight : Flight
    {
        public override void BookSeat()
        {
            Console.WriteLine($"Booking a seat for Economy Flight {FlightNumber}.");
        }
    }

    // Concrete class representing a Business class flight
    public class BusinessFlight : Flight
    {
        public override void BookSeat()
        {
            Console.WriteLine($"Booking a seat for Business Flight {FlightNumber}.");
        }
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            // Abstracting flight booking
            Flight economyFlight = new EconomyFlight
            {
                FlightNumber = "EF123",
                DepartureCity = "New York",
                DestinationCity = "Los Angeles",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(5)
            };

            Flight businessFlight = new BusinessFlight
            {
                FlightNumber = "BF456",
                DepartureCity = "London",
                DestinationCity = "Paris",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(3)
            };

            // Booking seats for flights (using abstraction)
            economyFlight.BookSeat();
            businessFlight.BookSeat();
        }
    }
}
























}