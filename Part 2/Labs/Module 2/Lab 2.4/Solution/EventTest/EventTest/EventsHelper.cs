using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
   /// <summary>
   /// This class is inspired by the EventsHelper class by IDesign.
   /// See http://www.idesign.net/Downloads/GetDownload/1823 .
   /// </summary>
   public static class EventsHelper
   {
      public static void Fire( this EventHandler del, object sender, EventArgs e )
      {
         UnsafeFire( del, sender, e );
      }

      public static void Fire<T>( this EventHandler<T> del, object sender, T t ) where T : EventArgs
      {
         UnsafeFire( del, sender, t );
      }

      private static void UnsafeFire( Delegate del, params object[] args )
      {
         if ( del == null )
         {
            return;
         }

         Delegate[] delegates = del.GetInvocationList();

         foreach ( Delegate sink in delegates )
         {
            try
            {
               sink.DynamicInvoke( args );
            }
            catch
            { 
            }
         }
      }
   }
}
