using Models;
using OrderProcessing.Helpers;

namespace Pipeline.Steps
{
    public class StockStep : IPipelineStep
    {
        public bool ContinueOnFailure => false;
        public async Task<OrderResult> ExecuteAsync(Order order)
        {
            Console.WriteLine("3. Stok güncelleniyor...");

            Console.WriteLine($"{order.ProductName} stoktan düşüldü : {order.Quantity}");

            return  new OrderSuccess(order.Id);
        }
    }
}