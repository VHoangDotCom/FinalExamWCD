using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CateID { get; set; }
        public string ProductName { get; set; }
        public int SuppilerID { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
       

        [ForeignKey("CateID")]
        public virtual Category Category { get; set; }
    }
}