using MyBookingProject.Models;
using MyBookingProject.Services;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create booking service
        BookingService service = new BookingService();

        // Add events
        service.AddEvent(new Event("Rock Concert", new DateTime(2025, 5, 10), "Club A2", 2));
        service.AddEvent(new Event("The Nutcracker Ballet", new DateTime(2025, 12, 15), "Mariinsky Theater", 5));

        // Create customers
        Customer anna = new Customer("Anna Ivanova", "anna@mail.com");
        Customer ivan = new Customer("Ivan Petrov", "ivan@mail.com");
        Customer kate = new Customer("Ekaterina Sidorova", "kate@mail.com");

        // Book tickets
        service.BookTicket("Rock Concert", anna);
        service.BookTicket("Rock Concert", ivan);

        // Attempt to book a ticket when no seats are available
        service.BookTicket("Rock Concert", kate);

        // Display information about all events
        service.ShowEventsInfo();
    }
}