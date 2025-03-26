using System;
using System.Collections.Generic;

namespace MyBookingProject.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public int MaxSeats { get; set; }
        public List<Ticket> ReservedTickets { get; private set; }

        public Event(string name, DateTime date, string place, int maxSeats)
        {
            Name = name;
            Date = date;
            Place = place;
            MaxSeats = maxSeats;
            ReservedTickets = new List<Ticket>();
        }


        public bool CheckAvailability()
        {   
            return ReservedTickets.Count < MaxSeats;
        }


        public int CreateTicket(Customer buyer)
        {
            Ticket newTicket = new Ticket(ReservedTickets.Count, this, buyer);
            ReservedTickets.Add(newTicket);
            return newTicket.Id;
        }
    }
}