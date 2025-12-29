namespace DesignPatterns;

using static System.Console;

public class SingletonDemo
{
    public void Run()
    {
        var b1 = SynchronizedLoadBalancer.GetLoadBalancer();
        var b2 = SynchronizedLoadBalancer.GetLoadBalancer();
        var b3 = SynchronizedLoadBalancer.GetLoadBalancer();
        var b4 = SynchronizedLoadBalancer.GetLoadBalancer();
        
        // Confirm these are the same instance
        if (b1 == b2 && b2 == b3 && b3 == b4)
        {
            WriteLine("Servers are equal");
        }
        
        var loadBalancer =  SynchronizedLoadBalancer.GetLoadBalancer();
        
        // Load balance 15 requests for a server
        for (int i = 0; i < 15; i++)
        {
            var server = loadBalancer.Server;
            WriteLine("Dispatch request to: " + server);
        }

        ReadKey();
    }
}

/// <summary>
/// Represents a Server Machine
/// </summary>
/// <param name="Name"></param>
/// <param name="Ip"></param>
public record Server(string Name, string Ip);

public sealed class LoadBalancer
{
    // Static members are 'eagerly initialized', that is,
    // immediately when class is loaded for the first time.
    // .NET guarantees thread safely for static intitialization
    private static readonly LoadBalancer Instance = new ();

    private readonly List<Server> _servers;
    private readonly Random _random = new();
    
    // Note: constructor is 'private'
    private LoadBalancer()
    {
        // Load list of available servers
        _servers =
        [
            new Server(Name: "ServerI", Ip: "120.14.220.18"),
            new Server(Name: "ServerII", Ip: "120.14.220.19"),
            new Server(Name: "ServerIII", Ip: "120.14.220.20"),
            new Server(Name: "ServerIV", Ip: "120.14.220.21"),
            new Server(Name: "ServerV", Ip: "120.14.220.22")
        ];
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return Instance;
    }
    
    // Simple, but effective load balancer
    public Server NextServer()
    {
        return _servers[_random.Next(_servers.Count)];
    }
}