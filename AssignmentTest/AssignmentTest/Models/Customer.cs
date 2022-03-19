using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentTest.Models
{
    public class Customer
    {
        public int CustID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}