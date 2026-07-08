using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; } //system generated 
        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; } //user input 
        [MaxLength(1000)]
        public string Description { get; set; } //user input 
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.1, (double)decimal.MaxValue)]
        public decimal Price { get; set; } //user input 
        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; } = 0; //default value 
        [MaxLength(300)]
        public string ImageUrl { get; set; } //user input 
        [Required]
        [ForeignKey("Category")] //forign key contraint 
        public int CategoryId { get; set; } //from list 
        //navigation property
        public Category Category { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //system generated 
        public bool IsAvaiable { get; set; } = true; //default value 
        
        //reverse navigation
        public List<Review> Reviews { get; set; } 
        
        //reverse navigation
        public List<ItemOrder> ItemOrders { get; set; }
    }
}
