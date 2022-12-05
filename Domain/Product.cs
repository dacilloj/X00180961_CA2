using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;
using static Domain.Categories;

namespace Domain
{
    public class Product
    {

        //github https://github.com/dacilloj/X00180961_CA2
        
        public int ProductId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ProductName { get; set; } = ""; 

        public double Price { get; set; }

        [Range(0,5)]
        public int? Rating { get; set; }

        public allowedCategoies category { get; set; }

        public allowedSizes size { get; set; }
    }
}
