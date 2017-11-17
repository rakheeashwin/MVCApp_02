using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp_02.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage ="Product Name is required.")]
        [MinLength(3,ErrorMessage ="Minimum 3 chars are needed.")]
        [MaxLength(50, ErrorMessage ="Max 50 chars allowed.")]
      //  [StringLength(50)]
      [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Units in Stock is required.")]
        [Range(0,200, ErrorMessage ="Stock Leeel is out of range.")]
        public short UnitsInStock { get; set; }

        [Required(ErrorMessage = "Unit Price is required.")]
        [DataType(DataType.Currency,ErrorMessage ="Incorrect format.")]
        [Display(Name = "Stock Level")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "In Use?")]
        public bool Discontinued { get; set; }

        
        public int? CategoryId { get; set; }
        
    }
}