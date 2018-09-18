using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide22
{
    public class MyDisposableClass : IDisposable
    {
        // Used to determine if Dispose()
        // has already been called.
        private bool _disposed = false;

        public void Dispose()
        {
            // Call our helper method.
            // Specifying "true" signifies that
            // the object user triggered the cleanup.
            CleanUp( true );

            // Now suppress finalization.
            GC.SuppressFinalize( this );
        }

        private void CleanUp( bool disposing )
        {
            // Be sure we have not already been disposed!
            if( !this._disposed )
            {
                // If disposing equals true, dispose all
                // managed resources.
                if( disposing )
                {
                    // Dispose managed resources.
                }
                // Clean up unmanaged resources here.
            }

            _disposed = true;
        }

        ~MyDisposableClass()
        {
            Console.Beep(); // NB!!!

            // Call our helper method.
            // Specifying "false" signifies that
            // the GC triggered the cleanup.
            CleanUp( false );
        }

        public void DoStuff()
        {
            Console.WriteLine( "Doing stuff..." );
        }

        public void DoMoreStuff()
        {
            Console.WriteLine("Doing more stuff...");
        }
    }
}
