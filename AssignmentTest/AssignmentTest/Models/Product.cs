using AssignmentTest.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssignmentTest.Models
{
    
    public class Product
    {
        //ID
        public int ID { get; set; }

        //CateID
        [DisplayName("Category Name")]
        public int CateID { get; set; }

        //Product Name
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        //Price
        [Required]
        public double Price { get; set; }

        [ForeignKey("CateID")]
        public virtual Category Category { get; set; }

        public Product()
        {
                
        }

        public Product(ProductViewModel pv)
        {
            this.ID = pv.ID;
            this.ProductName = pv.ProductName;
            this.Price = pv.Price;
        }
    }
}