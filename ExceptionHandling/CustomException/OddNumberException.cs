namespace ExceptionHandling.CustomException
{
    public class OddNumberException: Exception
    {
        public OddNumberException(){}
        
        public OddNumberException(string message) : base(message){}
        
        public OddNumberException(string message, Exception inner) : base(message, inner){}
        // public override string Message
        // {
        //     get
        //     {
        //         return "Divisor Cannot be Odd Number";
        //     }
        // }

        public override string? HelpLink
        {
            get
            {
                return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }
    }
}