using Models;

namespace Pipeline.Steps;

public class OrderValidationStep : IPipelineStep
{
    public Task ExecuteAsync(Order order)
    {
        Console.WriteLine("1. Sipariş doğrulaniyor....");

        if(order.Quantity<=0)
          throw new Exception("Geçersiz ürün miktari");
        if(order.TotalAmount<=0)
          throw new Exception("Geçersiz sipariş tutari");

        Console.WriteLine("Sipariş doğrulandi");

        return Task.CompletedTask;
    }
}