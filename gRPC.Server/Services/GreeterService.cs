using gRPC.Greeter;
using Grpc.Core;
using static gRPC.Greeter.Greeter;

namespace gRPC.Server.Services;

public class GreeterService : GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(
        HelloRequest request,
        ServerCallContext context)
    {
        _logger.LogInformation($"Greeting {request.Name}");

        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}