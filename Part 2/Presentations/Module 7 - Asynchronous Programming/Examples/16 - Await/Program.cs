using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide16
{
   class Program
   {
      static void Main( string[] args )
      {
         DoStuff();

         Console.ReadLine();
      }

      async static void DoStuff()
      {
         string url = "http://www.jp.dk";

         WebClient client = new WebClient();
         string result = await client.DownloadStringTaskAsync( url );

         Console.WriteLine( result );
      }
   }
}
