using Models;
using OrderProcessing.Helpers;

namespace Pipeline.Steps;

public class NotificationStep : IPipelineStep
{public bool ContinueOnFailure => true;
    public async Task<OrderResult> ExecuteAsync(Order order)
    {
        Console.WriteLine($"shipping method {order.ShippingMethod} değişti .... ");
        return new NotificationError("Notifice ederken hata oldu ");
        //return await Task.FromResult(new OrderSuccess(order.Id));
    }
}