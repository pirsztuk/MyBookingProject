using System;
using System.Collections.Generic;

namespace MyBookingProject.Models
{

    public class Ticket
    {
        public int Id { get; private set; }
        public Event BookedEvent { get; private set; }
        public Customer Buyer { get; private set; }

        public Ticket(int id, Event bookedEvent, Customer buyer)
        {
            Id = id;
            BookedEvent = bookedEvent;
            Buyer = buyer;
        }

    }
}