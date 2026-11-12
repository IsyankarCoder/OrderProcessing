using Models;
using OrderProcessing.Helpers;

namespace Pipeline.Steps;

public class PaymentStep : IPipelineStep
{
  public bool ContinueOnFailure => false;
    public async Task<OrderResult> ExecuteAsync(Order order)
    {
         Console.WriteLine("2. Ödeme gerçekletiriliyor..");

         await Task.Delay(500);


         //ödeme başarısızlığı simülasyonu
         bool paymentSuccessful=true;
         if(!paymentSuccessful)
           return  new PaymentError("Ödeme gerçekleştirilmedi");
         


         order.IsPaid=true;


         Console.WriteLine("Ödeme başarili");

         return  new OrderSuccess(order.Id);
       
    }
}