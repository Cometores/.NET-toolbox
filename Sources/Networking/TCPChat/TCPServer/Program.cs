namespace TCPServer;

internal static class Program
{
    private static async Task Main()
    {
        ServerObject server = new();
        await server.ListenAsync();
    }
}