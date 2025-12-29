namespace DesignPatterns;

/// <summary>
/// The 'Singleton' Class
/// </summary>
public class SynchronizedLoadBalancer
{
    static SynchronizedLoadBalancer instance;
    private List<string> servers = new List<string>();
    Random random = new();
    
    // Lock Syschronization object
    
    private static object locker = new();
    
    // Constructor (Protected)

    protected SynchronizedLoadBalancer()
    {
        // List of available servers
        servers.Add("ServerI");
        servers.Add("ServerII");
        servers.Add("ServerIII");
        servers.Add("ServerIV");
        servers.Add("ServerV");
    }

    public static SynchronizedLoadBalancer GetLoadBalancer()
    {
        // Support Multithreaded applications through
        // 'Double checked locking' pattern which (once
        // the instance exists) avoids locking each
        // time the method is invoked

        if (instance == null)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new SynchronizedLoadBalancer();
                }
            }
        }
        
        return instance;
    }
    
    // Simple, but effective random load balancer

    public string Server
    {
        get
        {
            int r = random.Next(servers.Count);
            return servers[r];
        }
    }
}
