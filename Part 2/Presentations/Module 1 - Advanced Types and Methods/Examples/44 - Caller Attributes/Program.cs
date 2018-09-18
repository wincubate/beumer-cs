using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module01.Slide44
{
   class Program
   {
      static void Main( string[] args )
      {
         Log( "Houston, we have a problem!" );
      }

      static void Log(
         string logLine,
         [CallerMemberName] string callerName = null, 
         [CallerFilePath] string callerFilePath = null,
         [CallerLineNumber] int callerLine = -1
      )
      {
         Console.WriteLine( logLine + " was reported. Detailed info:" + Environment.NewLine );
         Console.WriteLine( "Caller Name: {0}", callerName );
         Console.WriteLine( "Caller FilePath: {0}", callerFilePath );
         Console.WriteLine( "Caller Line number: {0}", callerLine );
      }
   }
}
