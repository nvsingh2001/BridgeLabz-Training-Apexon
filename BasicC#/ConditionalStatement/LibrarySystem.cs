using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class LibrarySystem
    {
        /*
         * Design a library reservation system in C#. 
         * Allow users to check the availability of books and reserve them. 
         * Use conditional statements to manage the reservation process, considering factors like book availability, user limits, and reservation duration.
         */

        bool[] booksStatus = new bool[100]; // false means available, true means reserved

        public void ReserveBook(int bookId, int userId)
        {
            if (bookId < 0 || bookId >= booksStatus.Length)
            {
                Console.WriteLine("Invalid book ID.");
                return;
            }
            if (!booksStatus[bookId])
            {
                booksStatus[bookId] = true;
                Console.WriteLine($"User {userId} has successfully reserved book {bookId}.");
            }
            else
            {
                Console.WriteLine($"Book {bookId} is already reserved.");
            }
        }

        public void CheckAvailability(int bookId)
        {
            if (bookId < 0 || bookId >= booksStatus.Length)
            {
                Console.WriteLine("Invalid book ID.");
                return;
            }
            if (!booksStatus[bookId])
            {
                Console.WriteLine($"Book {bookId} is available for reservation.");
            }
            else
            {
                Console.WriteLine($"Book {bookId} is currently reserved.");
            }
        }

        public bool IsAvailable(int bookId)
        {
            return booksStatus[bookId];
        }

        public void returnBook(int bookId, int userId)
        {
            if (bookId < 0 || bookId >= booksStatus.Length)
            {
                Console.WriteLine("Invalid book ID.");
                return;
            }
            if (booksStatus[bookId])
            {
                booksStatus[bookId] = false;
                Console.WriteLine($"User {userId} has returned book {bookId}.");
            }
            else
            {
                Console.WriteLine($"Book {bookId} was not reserved.");
            }
        }

        public static void librarySystem()
        {
            LibrarySystem library = new LibrarySystem();
            library.CheckAvailability(10);
            library.ReserveBook(10, 1);
            library.CheckAvailability(10);
            library.returnBook(10, 1);
            library.CheckAvailability(10);
        }
    }
}
