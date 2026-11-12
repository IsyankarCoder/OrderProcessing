using Models;
using OrderProcessing.Helpers;

namespace Pipeline.Steps;

public class OrderValidationStep : IPipelineStep
{
    public bool ContinueOnFailure => false;
    public async Task<OrderResult> ExecuteAsync(Order order)
    {
        Console.WriteLine("1. Sipariş doğrulaniyor....");

        if(order.Quantity<=0)
           return  new ValidationError("Geçersiz ürün miktari");
        if(order.Amount<=0)
          return new ValidationError("Geçersiz sipariş tutari");

        Console.WriteLine("Sipariş doğrulandi");

        return new OrderSuccess(order.Id);
    }
}