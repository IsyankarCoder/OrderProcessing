using Models;
namespace OrderProcessing.Handlers;

public class BlacklistHandler 
         : OrderHandler
{

    public override async Task HandleAsync(Order order)
    {
        Console.WriteLine("Blacklist kontrolü .... ");        
        bool isBlackListed = false;

        if(isBlackListed)
          throw new Exception("Müşteri kara listede ! ");

        Console.WriteLine("Blacklist kontrolü başarili...");

        if(Next!=null)
            await Next.HandleAsync(order);

    }
}