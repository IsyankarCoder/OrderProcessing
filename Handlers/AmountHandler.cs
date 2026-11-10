using Models;
namespace OrderProcessing.Handlers;

public class AmountHandler : OrderHandler
{
    public override async  Task HandleAsync(Order order)
    {
        Console.WriteLine("Tutar kontrolü ....");
        if(order.Amount>100000)
           throw new Exception("Sipariş tutari limitin üzerinde !");
         
         Console.WriteLine("Tutar kontrolü başarili...");
         
          
         if(Next!=null)
          await Next.HandleAsync(order);
    }
}