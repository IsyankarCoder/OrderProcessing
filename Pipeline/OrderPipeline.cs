using Models;
using OrderProcessing.Helpers;


namespace Pipeline
{
    public class OrderPipeline
    {
        private readonly List<IPipelineStep> _steps = new();

        public OrderPipeline AddStep(IPipelineStep pipelineStep)
        {
            _steps.Add(pipelineStep);
            return this;

        }

        public async Task<IReadOnlyList<OrderResult>>  ExecuteAsync(Order order)
        {
              var results = new List<OrderResult>();
              
            foreach (var step in _steps)
            {
                var result= await step.ExecuteAsync(order);

                 results.Add(result);

            if (result is not OrderSuccess && !step.ContinueOnFailure)
                break;
            } 
            return results; 
        }
    }
}