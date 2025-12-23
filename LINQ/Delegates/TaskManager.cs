namespace LINQ.Delegates;

public class TaskManager
{
    public event EventHandler TaskCompleted;
    
    protected virtual void OnTaskCompleted()
    {
        TaskCompleted?.Invoke(this, EventArgs.Empty);
    }
    
    public void RunTask()
    {
        Console.WriteLine("Task Started!");
        OnTaskCompleted();
    }
}