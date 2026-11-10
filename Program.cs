using Models;
using OrderProcessing.Builders;
using OrderProcessing.Handlers;
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
       /*var order = new Order
       {
           Id = 1001,
           CustomerName = "Ahmet",
           ProductName = "Laptop",
           Quantity = 2,
           Amount = 50000,
           Address = "Ankara",
           ShippingMethod = "EXPRESS",
           PaymentMethod = "CREDIT_CARD"
       };*/

       var order = new OrderBuilder()
                    .SetCustomer("Volkan")
                    .SetProduct("Laptop",2,50000)
                    .SetAddress("Ankara")
                    .SetShippingMethod("EXPRESSS")
                    .SetPaymentMethod("CREDIT_CARD")
                    .SetShippingMethod("NORMAL")
                    .Build(); 
         

        var blacklist=new BlacklistHandler();
        blacklist
           .SetNext(new AmountHandler())
           .SetNext(new ProductHandler());

        


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