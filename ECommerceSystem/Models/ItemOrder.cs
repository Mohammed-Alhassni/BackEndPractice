namespace ECommerceSystem.Models;

public class ItemOrder
{

    //////////////////////////////////////////
    //Order --------- ItemOrder -------- Product 
    //1 ------------- M | M ------------ 1
    ////////////////////////////////////////
    
    public int ItemOrderID { get; set; }
    public int ProductID { get; set; }
    public int OrderID { get; set; }
    public int Quantity { get; set; }
}