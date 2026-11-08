using Models;
using Pipeline;
using Pipeline.Steps;

internal class Program
{
    /*
      Sipariş bilgilerini al.
      Siparişin geçerli olup olmadığını kontrol et.
      Ödeme işlemini gerçekleştir.
      Stoktan ürünleri düş.
      Kargoya gönder.
      Müşteriye bildirim gönder.
    */

    /// <summary>     
    ///Pipeline                --> Siparişin işlem aşamalarını yürütmek
    ///Chain of Responsibility --> Siparişin onay/ret kontrollerini yönetmek
    ///Builder                 --> Sipariş nesnesini adım adım oluşturmak
    /// </summary>
    /// <param name="args"></param>
    private static async Task Main(string[] args)
    {
        
        var order =new Order
        {
            Id = 1001,
            CustomerName = "Ahmet",
            ProductName = "Laptop",
            Quantity = 2,
            TotalAmount = 50000
        };

        var pipeline = new OrderPipeline()
                          .AddStep(new OrderValidationStep())
                          .AddStep(new PaymentStep())
                          .AddStep(new StockStep())
                          .AddStep(new ShippingStep())
                          .AddStep(new NotificationStep());

        try
        {
            await pipeline.ExecuteAsync(order);
            Console.WriteLine("Sipariş tamamlandi");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"Sipariş başarısız: {ex.Message}");
        }




    }
}