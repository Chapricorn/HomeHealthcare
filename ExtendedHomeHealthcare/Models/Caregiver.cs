﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtendedHomeHealthcare.Models
{
    public class Caregiver
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string StreetName { get; set; }
        public string StreetName2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}