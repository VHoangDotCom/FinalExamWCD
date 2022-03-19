using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssignmentTest.Models.ViewModel
{
    public class ProductViewModel
    {
        //ID
        [DisplayName("Product ID")]
        public int ID { get; set; }

        //Product Name
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Please enter Product name !")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Length must be at least 2 characters and maximum 100 characters !")]
        public string ProductName { get; set; }

        //Price
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Please enter Price !")]
        public double Price { get; set; }


        public ProductViewModel()
        {

        }

        public ProductViewModel(Product pv)
        {
            this.ID = pv.ID;
            this.ProductName = pv.ProductName;
            this.Price = pv.Price;
        }
    }
}