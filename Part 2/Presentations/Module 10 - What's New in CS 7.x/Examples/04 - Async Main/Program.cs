using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wincubate.CS7x.Slide04
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuffAsync().GetAwaiter().GetResult();
        }

        static async Task DoStuffAsync()
        {
            HttpClient client = new HttpClient();
            string s = await client.GetStringAsync("http://www.jp.dk");
            Console.WriteLine( s.Substring( 0, 100 ) );
        }
    }
}
