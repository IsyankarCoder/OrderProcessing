using Models;


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

        public async Task ExecuteAsync(Order order)
        {
            foreach (var step in _steps)
            {
                await step.ExecuteAsync(order);
            }
        }
    }
}