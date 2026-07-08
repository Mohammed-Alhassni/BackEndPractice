using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; } //system generated 
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; } //from list
        public User User { get; set; } //navigation property 
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; } //from list
        public Product Product { get; set; } //navigation property 
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } //user input 
        [MaxLength(1000)]
        public string Comment { get; set; } //user input
        [Required]
        public DateTime ReviewTime { get; set; } //system generated 
    }
}
