using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Disposable
{
    class Program
    {
        static void Main( string[] args )
        {
            FileWriter fileWriter = new FileWriter();
            fileWriter.Log();
            fileWriter.Log();
            fileWriter.Log();

            // FileWriter is no longer needed
            fileWriter = null;

            Console.WriteLine( "Waiting to terminate..." );
            Console.ReadLine();
        }
    }
}
