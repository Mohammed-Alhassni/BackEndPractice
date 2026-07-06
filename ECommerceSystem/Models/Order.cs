using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSystem.Models
{
    internal class Order
    {
        public int OrderId { get; set; } //system generated 
        public int UserId { get; set; } //from list 
        public DateTime OrderDate { get; set; } //system generated
        public decimal TotalAmount { get; set; } //user input
        public string Status { get; set; } //user input 
        public string ShippingAddress { get; set; } //user input
        public string PaymentMethod { get; set; } //user input 

    }
}
