using Models;

namespace OrderProcessing.Helpers;

public record OrderBuildSuccess(Order Order);
public record OrderBuildFailure(string Message);

public union OrderBuildResult(
    OrderBuildSuccess,
    OrderBuildFailure
);
