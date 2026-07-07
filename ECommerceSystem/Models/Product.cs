using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSystem.Models
{
    internal class Product
    {
        public int ProductId { get; set; } //system generated 
        public string ProductName { get; set; } //user input 
        public string Description { get; set; } //user input 
        public double Price { get; set; } //user input 
        public int StockQuantity { get; set; } = 0; //default value 
        public string ImageUrl { get; set; } //user input 
        public int CategoryId { get; set; } //from list 
        public DateTime CreatedAt { get; set; } //system generated 
        public bool IsAvaiable { get; set; } = true; //default value 
    }
}
