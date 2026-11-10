using Models;

namespace OrderProcessing.Builders;

public class OrderBuilder
              :IOrderBuilder
{

    private int _id;
    private string _customerName = string.Empty;
    private string _productName = string.Empty;
    private int _quantity;
    private decimal _amount;
    private string _address = string.Empty;
    private string _shippingMethod = string.Empty;
    private string _paymentMethod = string.Empty; 
    public Order Build()
    {
        if (string.IsNullOrWhiteSpace(_customerName))
            throw new Exception("Müşteri bilgisi zorunludur!");

        if (string.IsNullOrWhiteSpace(_productName))
            throw new Exception("Ürün bilgisi zorunludur!");

        if (_quantity <= 0)
            throw new Exception("Miktar geçersiz!");

        if (string.IsNullOrWhiteSpace(_address))
            throw new Exception("Adres zorunludur!");

        return  new Order(id:_id,
                          customerName:_customerName,
                          productName:_productName,
                          quantity:_quantity,
                          address:_address,
                          shippingMethod:_shippingMethod,
                          paymentMethod:_paymentMethod,
                          amount:_amount
                         );       
        
    }

    public IOrderBuilder SetId(int id)
    {
         _id=id;
         return this;
    }

    public IOrderBuilder SetCustomer(string customerName)
    {
        _customerName=customerName;
        return this;
    }

    public IOrderBuilder SetProduct(string productName, int quantity,decimal amount)
    {
        _productName=productName;
        _quantity=quantity;
        _amount=amount;
        return this;
    }

    public IOrderBuilder SetAmount(decimal amount)
    {
       _amount=amount;
       return this;
    }

    IOrderBuilder IOrderBuilder.SetAddress(string address)
    {
      _address=address;
      return this;
    }

    public IOrderBuilder SetShippingMethod(string shippingMethod)
    {
       _shippingMethod=shippingMethod;
       return this;
    }

    public IOrderBuilder SetPaymentMethod(string paymentMethod)
    {
        _paymentMethod=paymentMethod;
        return this;
    }
}
