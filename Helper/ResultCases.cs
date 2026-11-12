namespace OrderProcessing.Helpers;

public sealed record Success<T>(T Value);
public sealed record Failure(Error Error);

