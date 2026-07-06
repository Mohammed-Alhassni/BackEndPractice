using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSystem.Models
{
    internal class User
    {
        public int UserId { get; set; } //system generated 
        public string UserName { get; set; } //user input 
        public string Email { get; set; } //user input 
        public string PasswordHash { get; set; } //system calculated 
        public string FullName { get; set; } //user input 
        public string PhoneNumber { get; set; } //user input 
        public string Address { get; set; } //user input 
        public DateTime RegistrationDate { get; set; } //system generated 
        public bool IsActive { get; set; } = true;  //default value 
    }
}
