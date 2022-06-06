using MediatR;
using MediatR.Pipeline;

namespace API.Application.Common;

public class RequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse> where TRequest: IRequest<TResponse>
{
    private readonly ILogger<RequestPostProcessor<TRequest, TResponse>> _logger;

    public RequestPostProcessor(ILogger<RequestPostProcessor<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        _logger.LogWarning($"Handled {typeof(TRequest)} with response {typeof(TResponse)}");
    }
}
