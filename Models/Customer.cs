using System;
using System.Collections.Generic;

namespace MyBookingProject.Models
{

    public class Customer(string name, string email)
    {

        public string Name { get; } = name;
        public string Email { get; } = email;
    }
}