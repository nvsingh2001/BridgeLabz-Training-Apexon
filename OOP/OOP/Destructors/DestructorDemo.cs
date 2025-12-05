using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Destructors
{
    internal class DestructorDemo : IDisposable
    {
        public int x;
        private bool disposedValue;

        public DestructorDemo()
        {
            Console.WriteLine("Object Created.");
        }

        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} got destroyed!");
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are Already Destroyed by Dispose Method");
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~DestructorDemo()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
