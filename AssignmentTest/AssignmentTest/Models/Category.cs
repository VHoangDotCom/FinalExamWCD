using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssignmentTest.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Please enter Category name !")]
        public string CategoryName { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}