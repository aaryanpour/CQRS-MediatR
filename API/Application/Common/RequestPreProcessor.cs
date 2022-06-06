using MediatR.Pipeline;

namespace API.Application.Common
{
    public class RequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    {

        private ILogger<RequestPreProcessor<TRequest>> _logger;

        public RequestPreProcessor(ILogger<RequestPreProcessor<TRequest>> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            _logger.LogWarning($"Handling {typeof(TRequest)} Request");
        }
    }
}
