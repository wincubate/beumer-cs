using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Disposable
{
    class FileWriter
    {
        protected FileStream _fs;

        public FileWriter()
        {
            _fs = File.Create( @"FileWriter.txt" );
        }

        public void Log()
        {
            string s = DateTime.Now.ToLongTimeString() + Environment.NewLine;
            _fs.Write( Encoding.ASCII.GetBytes( s ), 0, s.Length );
        }
    }
}
