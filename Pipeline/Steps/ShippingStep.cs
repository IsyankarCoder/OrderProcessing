using Models;
using OrderProcessing.Helpers;

namespace Pipeline.Steps
{
    public class ShippingStep : IPipelineStep
    {
        public bool ContinueOnFailure => false;
        public async Task<OrderResult> ExecuteAsync(Order order)
        {
           Console.WriteLine("4. Kargo oluşturuluyor...");

            if (!order.IsPaid)
            {
              return  new ShippingError("Ödeme yapilmadan kargo oluşturulmaz ");

            }

            order.IsShipped=true;

            Console.WriteLine("Kargo oluşturuldu...");

            return  new OrderSuccess(order.Id);
        }
    }
}