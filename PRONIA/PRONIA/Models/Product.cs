using System;
using System.Collections.Generic;

namespace PRONIA.Models
{
    public class Product:BaseEntity
    {

       
        public string Name { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
        
}
