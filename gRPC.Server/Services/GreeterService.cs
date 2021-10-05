using gRPC.Greeter;
using Grpc.Core;
using static gRPC.Greeter.Greeter;

namespace gRPC.Server.Services;

public class GreeterService : GreeterBase
{
    public override Task<HelloReply> SayHello(
        HelloRequest request,
        ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}