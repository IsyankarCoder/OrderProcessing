using Models;

namespace Pipeline.Steps
{
    public class StockStep : IPipelineStep
    {
        public Task ExecuteAsync(Order order)
        {
            Console.WriteLine("3. Stok güncelleniyor...");

            Console.WriteLine($"{order.ProductName} stoktan düşüldü : {order.Quantity}");

            return Task.CompletedTask;
        }
    }
}