using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    [Index(nameof(UserName), IsUnique =true)]
    [Index(nameof(Email), IsUnique = true)]
    internal class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } //system generated 
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } //user input 
        [Required]
        [MaxLength(150)]
        public string Email { get; set; } //user input 
        [Required]
        [MaxLength(256)]
        public string PasswordHash { get; set; } //system calculated
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } //user input 
        // omit required so it can be nullable, this applied to reference types, values types needs ?
        [MaxLength(20)]
        public string PhoneNumber { get; set; } //user input 
        // omit required so it can be nullable
        [MaxLength(300)]
        public string Address { get; set; } //user input 
        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow; //system generated 
        public bool IsActive { get; set; } = true;  //default value 
    }
}
