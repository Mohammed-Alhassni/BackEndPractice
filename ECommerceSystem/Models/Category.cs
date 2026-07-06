using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceSystem.Models
{
    internal class Category
    {
        public int CategoryId { get; set; } //system generated
        public string CategoryName { get; set; } //user input 
        public string Description { get; set; } //user input 
        public string ImageUrl { get; set; } //user input 

    }
}
