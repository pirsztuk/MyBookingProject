using System;
using System.Collections.Generic;
using MyBookingProject.Models;

namespace MyBookingProject.Services
{
    
    public class BookingService
    {
        // Array of events
        public List<Event> Events { get; }


        public BookingService()
        {
            Events = new List<Event>();
        }


        public void AddEvent(Event newEvent)
        {
            Events.Add(newEvent);
            Console.WriteLine($"New event \"{newEvent.Name}\" has been added successfully!");
        }


        public void ShowEventsInfo()
        {
            foreach (Event currentEvent in Events)
            {
                Console.WriteLine($"[] Event Name: {currentEvent.Name}, Date: {currentEvent.Date}, Place: {currentEvent.Place}, MaxSeats: {currentEvent.MaxSeats}, ReservedSeats: {currentEvent.ReservedTickets.Count}");
            }
        }


        public bool BookTicket(string eventName, Customer buyer)
        {
            foreach (Event currentEvent in Events)
            {
                if (currentEvent.Name == eventName)
                {
                    if (currentEvent.CheckAvailability())
                    {
                        int ticketId = currentEvent.CreateTicket(buyer);
                        Console.WriteLine($"[] Ticket №{ticketId} for Event {currentEvent.Name} for Customer: {buyer.Name}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Booking failed: No available seats for {currentEvent.Name}");
                        return false;
                    }
                    
                }
            }

            return false;
        }
    }
}