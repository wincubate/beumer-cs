using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Disposable
{
    class FileWriter : IDisposable
    {
        private bool _disposed = false;
        protected FileStream _fs;

        public FileWriter()
        {
            _fs = File.Create( @"FileWriter.txt" );
        }

        ~FileWriter()
        {
            CleanUp( false );
        }

        public void Dispose()
        {
            CleanUp( true );
            GC.SuppressFinalize( this );
        }

        private void CleanUp( bool disposing )
        {
            if( _disposed == false )
            {
                if( disposing )
                {
                    // Dispose managed here
                    _fs.Dispose();
                }

                // Clean up unmanaged here.
            }
            _disposed = true;
        }

        public void Log()
        {
            if( _disposed == true )
            {
                throw new ObjectDisposedException( "Object is already disposed!" );
            }

            string s = DateTime.Now.ToLongTimeString() + Environment.NewLine;
            _fs.Write( Encoding.ASCII.GetBytes( s ), 0, s.Length );
        }
    }
}
