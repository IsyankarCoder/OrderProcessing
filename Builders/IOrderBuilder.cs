using Models;

public interface IOrderBuilder
{    
    IOrderBuilder SetId(int id);

    IOrderBuilder SetCustomer(string customerName);

    IOrderBuilder SetProduct(string productName, int quantity,decimal amount);

    IOrderBuilder SetAmount(decimal amount);

    IOrderBuilder SetAddress(string address);

    IOrderBuilder SetShippingMethod(string shippingMethod);

    IOrderBuilder SetPaymentMethod(string paymentMethod);

    Order Build();
}