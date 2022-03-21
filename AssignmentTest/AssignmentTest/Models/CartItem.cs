using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentTest.Models
{
    public class CartItem
    {
        public string ProName { get; set; }
        public int proID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double subtotal { get { return Price * Quantity; } }
    }
}