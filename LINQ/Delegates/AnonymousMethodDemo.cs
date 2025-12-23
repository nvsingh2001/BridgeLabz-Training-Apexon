namespace LINQ.Delegates;

class Button
{
    public delegate void ClickHandler();
    
    public event ClickHandler OnClick;

    public void Click()
    {
        if (OnClick is not null)
        {
            OnClick();
        }
    }
}

public class AnonymousMethodDemo
{
    delegate void ShowMessage(string message);

    public static void Run()
    {
        ShowMessage message = delegate(string message)
        {
            Console.WriteLine("Message: " + message);
        };
        
        message("Hello World!");

        Button btn = new Button();

        btn.OnClick += delegate()
        {
            Console.WriteLine("Button clicked");
        };
        
        btn.Click();
    }
}