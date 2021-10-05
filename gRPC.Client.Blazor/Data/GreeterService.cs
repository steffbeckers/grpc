using gRPC.Greeter;
using Grpc.Net.Client;
using static gRPC.Greeter.Greeter;

namespace gRPC.Client.Blazor.Data;

public class GreeterService
{
    private readonly GreeterClient _client;

    public GreeterService(IConfiguration configuration)
    {
        _client = new GreeterClient(GrpcChannel.ForAddress(configuration.GetValue<string>("gRPC:Endpoint")));
    }

    public async Task<HelloReply> SayHelloAsync(string name)
    {
        return await _client.SayHelloAsync(new HelloRequest { Name = name });
    }
}