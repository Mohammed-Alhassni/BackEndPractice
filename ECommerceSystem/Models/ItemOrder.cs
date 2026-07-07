using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models;

internal class ItemOrder
{

    //////////////////////////////////////////
    //Order --------- ItemOrder -------- Product 
    //1 ------------- M | M ------------ 1
    ////////////////////////////////////////
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ItemOrderID { get; set; } //system generated 
    [Required]
    [ForeignKey("Product")]
    public int ProductID { get; set; }
    public Product Product { get; set; } //navigation
    [Required]
    [ForeignKey("Order")]
    public int OrderID { get; set; }
    public Order Order { get; set; }
    
    [Required]
    [Range(1, 999)]
    public int Quantity { get; set; } //user input 
}