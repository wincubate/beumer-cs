using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamicool
{
   class Program
   {
      static void Main( string[] args )
      {
         List<object> mixOfObjects = new List<object>()
         {
            true,
            87,
            "Hello World",
            176.0
         };

         ObjectHandler handler = new ObjectHandler();

         foreach( dynamic o in mixOfObjects )
         {
            handler.Handle( o );
         }
      }
   }

   public class ObjectHandler
   {
      public void Handle( bool o )
      {
         Console.WriteLine( "Handling bool...\t" + o );
      }
      public void Handle( int o )
      {
         Console.WriteLine( "Handling int...\t\t" + o );
      }
      public void Handle( double o )
      {
         Console.WriteLine( "Handling double...\t" + o );
      }
      public void Handle( string o )
      {
         Console.WriteLine( "Handling string...\t" + o );
      }
      //public void Handle( object o )
      //{
      //   Console.WriteLine( "Handling object...\t" + o );
      //}
   }
}
