using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSystem.Models
{
    internal class Review
    {
        public int ReviewId { get; set; } //system generated 
        public int UserId { get; set; } //from list
        public int ProductId { get; set; } //from list
        public int Rating { get; set; } //user input 
        public string Comment { get; set; } //user input
        public DateTime ReviewTime { get; set; } //system generated 
    }
}
