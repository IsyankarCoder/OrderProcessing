namespace OrderProcessing.Helpers;

public enum ErrorType
{
    Validation,
    Business,
    NotFound,
    Conflict,
    External     
}

public sealed record Error(int ErrorCode, string Message,ErrorType ErrorType);