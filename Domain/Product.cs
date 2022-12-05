using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        //[StringLength()]
        public string ProductName { get; set; } = ""; 

        public double Price { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        public Categories category { get; set; }

        public Sizes size { get; set; }
    }
}
