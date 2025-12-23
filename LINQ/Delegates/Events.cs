namespace LINQ.Delegates;

public class Events
{
    public delegate void Notify();

    public event Notify ProcessCompleted;

    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }

    public void Start()
    {
        Console.WriteLine("Process Started!");
        OnProcessCompleted();
    }

}