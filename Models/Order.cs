namespace Models
{
    public class Order
    {
    public int Id { get; private set; }
    public string CustomerName { get; private set; } = "";
    public string ProductName { get; private set; } = "";
    public int Quantity { get; private set; }
    public decimal Amount { get; private set; }

    public string Address { get; private set; } = "";
    public string ShippingMethod { get; private set; } = "";
    public string PaymentMethod { get; private set; } = "";

    public bool IsPaid { get;  set; }
    public bool IsShipped { get;  set; }

    internal Order(int id, 
                   string customerName,
                   string productName,
                   int quantity,
                   string address,
                   decimal amount,
                   string shippingMethod,
                   string paymentMethod)
    {
        Id = id;
        CustomerName = customerName;
        ProductName = productName;
        Quantity = quantity;
        Amount = amount;
        Address = address;
        ShippingMethod = shippingMethod;
        PaymentMethod = paymentMethod;
    }


    public void Demo()
    {
            
    }
    }
 
}