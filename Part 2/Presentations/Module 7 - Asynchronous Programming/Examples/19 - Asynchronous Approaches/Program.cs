using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide19
{
   class Program
   {
      static string Url = "http://www.jp.dk";
      
      static void Main( string[] args )
      {
         //Synchronous();
         //AsynchronousProgrammingModel();
         //EventBasedAsynchronousPattern();
         //TaskBasedAsynchrony();
         //AsynchronousProgrammingModelViaTasks();
 
         Console.ReadLine();
      }

      #region Synchronous

      static void Synchronous()
      {
         WebClient client = new WebClient();
         string s = client.DownloadString( Url );
         Console.WriteLine( s );
      }

      #endregion

      #region Asynchronous Programming Model (APM)

      static void AsynchronousProgrammingModel()
      {
         HttpWebRequest request = WebRequest.Create( Url ) as HttpWebRequest;
         request.BeginGetResponse( Callback, request );
      }

      static void Callback( IAsyncResult iar )
      {
         HttpWebRequest request = iar.AsyncState as HttpWebRequest;
         HttpWebResponse response = request.EndGetResponse( iar ) as HttpWebResponse;

         Console.WriteLine( response.StatusCode );
      }

      #endregion

      #region Event-based Asynchronous Pattern

      static void EventBasedAsynchronousPattern()
      {
         WebClient client = new WebClient();
         client.DownloadStringCompleted += OnDownloadStringCompleted;
         client.DownloadStringAsync( new Uri( Url ) );
      }

      static void OnDownloadStringCompleted( object sender, DownloadStringCompletedEventArgs e )
      {
         if( e.Error != null )
         {
            // Exception
            Console.WriteLine( e.Error.Message );
         }
         else if ( e.Cancelled )
         {
            // Operation cancelled
            Console.WriteLine( "DownloadString cancelled" );
         }
         else
         {
            Console.WriteLine( e.Result );
         }
      }

      #endregion

      #region Task-based Asynchrony

      static async void TaskBasedAsynchrony()
      {
         WebClient client = new WebClient();
         string s = await client.DownloadStringTaskAsync( Url );
         Console.WriteLine( s );
      }

      #endregion

      #region Bonus: Asynchronous Programming Model (APM) via Tasks

      static async void AsynchronousProgrammingModelViaTasks()
      {
         HttpWebRequest request = WebRequest.Create( Url ) as HttpWebRequest;
         HttpWebResponse response =
            await Task<WebResponse>.Factory.FromAsync(
               request.BeginGetResponse,
               request.EndGetResponse,
               request )
            as HttpWebResponse;

         Console.WriteLine( response.StatusCode );
      }

      #endregion
   }
}
