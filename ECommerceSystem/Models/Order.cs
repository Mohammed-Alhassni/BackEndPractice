using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; } //system generated 
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; } //from list 
        public User User { get; set; } //navigation property
        [Required]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow; //system generated
        [Required]
        [Range(0, (double)decimal.MaxValue)] //cast to double because Range() expects double
        public decimal TotalAmount { get; set; } //user input
        [Required]
        [MaxLength(30)]
        public string Status { get; set; } //user input 
        [Required]
        [MaxLength(300)]
        public string ShippingAddress { get; set; } //user input 
        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } //user input 

        //reverse navigation
        public List<ItemOrder> ItemOrders { get; set; }
    }
}
