using Models;
namespace OrderProcessing.Handlers;

public class ProductHandler:OrderHandler
{

    public override  async Task HandleAsync(Order order)
    {
        Console.WriteLine("Ürün kontrolü ...");
        Console.WriteLine("Ürün siparişe uygun .... ");
        
        
        if(Next!=null)
        await Next.HandleAsync(order);
    }
    
}