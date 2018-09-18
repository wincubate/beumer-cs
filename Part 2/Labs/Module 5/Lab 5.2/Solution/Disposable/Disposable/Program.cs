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
            using( FileWriter fileWriter = new FileWriter() )
            {
                fileWriter.Log();
                fileWriter.Log();
                fileWriter.Log();

                // FileWriter is no longer needed
            }

            Console.WriteLine( "Waiting to terminate..." );
            Console.ReadLine();
        }
    }
}
