using Models;

namespace Pipeline.Steps
{
    public class ShippingStep : IPipelineStep
    {
        public Task ExecuteAsync(Order order)
        {
           Console.WriteLine("4. Kargo oluşturuluyor...");

            if (!order.IsPaid)
            {
                throw new Exception("Ödeme yapilmadan kargo oluşturulmaz ");

            }

            order.IsShipped=true;

            Console.WriteLine("Kargo oluşturuldu...");

            return Task.CompletedTask;
        }
    }
}