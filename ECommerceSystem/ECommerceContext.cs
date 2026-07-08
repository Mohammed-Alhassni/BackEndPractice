using ECommerceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSystem
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
