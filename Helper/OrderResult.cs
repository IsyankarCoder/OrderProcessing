namespace OrderProcessing.Helpers;
public abstract record OrderResult;

public record OrderSuccess(int OrderId) : OrderResult;

public record ValidationError(string Message) : OrderResult;

public record PaymentError(string Message) : OrderResult;

public record StockError(string Message) : OrderResult;

public record ShippingError(string Message) : OrderResult;

public record NotificationError(string Message):OrderResult;