using Models;

namespace OrderProcessing.Handlers
{
    public abstract class OrderHandler
    {
        protected OrderHandler? Next;

        public OrderHandler SetNext(OrderHandler next)
        {
            Next =next;
            return next;
        }

        public abstract Task HandleAsync(Order order);
    }
}

    
