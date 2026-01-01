namespace Multithreading;

public class ThreadSynchronizationDemo
{
    public static void Run()
    {
        BookMyShow show = new BookMyShow();
        
        Thread t1 = new Thread(show.TicketBooking){Name = "Thread1"};
        Thread t2 = new Thread(show.TicketBooking){Name = "Thread2"};
        Thread t3 = new Thread(show.TicketBooking){Name = "Thread3"};
        
        t1.Start();
        t2.Start();
        t3.Start();
    }

    public class BookMyShow
    {
        private object _lockObject = new Object();

        private int _availableTickets = 3;

        private static int i = 1, j = 2, k = 3;

        public void BookTicket(string name, int wantedtickets)
        {
            lock (_lockObject)
            {
                if (wantedtickets <= _availableTickets)
                {
                    Console.WriteLine(name + " wanted " + wantedtickets);
                    _availableTickets -= wantedtickets;
                }
                else
                {
                    Console.WriteLine("No tickets available to book.");
                }
            }
        }

        public void TicketBooking()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("Thread1"))
            {
                BookTicket(name, i);
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(name, j);
            }
            else
            {
                BookTicket(name, k);
            }
        }

    }
}