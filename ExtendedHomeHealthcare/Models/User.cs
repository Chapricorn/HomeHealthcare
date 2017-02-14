using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtendedHomeHealthcare.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string EMail { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public State States { get; set; }
        public int StateId { get; set; }
        //public ZipCode ZipCode { get; set; }
        public int ZipCodeId { get; set; }
    }
}