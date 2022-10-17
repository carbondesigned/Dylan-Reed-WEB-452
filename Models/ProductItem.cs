using System;
using Microsoft.VisualBasic;

namespace web452_assignment1.Models
{
    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        // customer review based on a half-rating scale of 1-5 
        public double CustomerReview { get; set; }
    }
}

