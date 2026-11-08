using Models;

namespace Pipeline.Steps;

public class PaymentStep : IPipelineStep
{
    public async Task ExecuteAsync(Order order)
    {
         Console.WriteLine("2. Ödeme gerçekletiriliyor..");

         await Task.Delay(500);

         order.IsPaid=true;

         Console.WriteLine("Ödeme başarili");
       
    }
}