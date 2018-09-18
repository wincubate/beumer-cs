using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wincubate.Module07.Slide18
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private async void OnThrowHandledClick( object sender, RoutedEventArgs e )
      {
         using ( WebClient client = new WebClient() )
         {
            try
            {
               string data = await client.DownloadStringTaskAsync( "http://does.not.exist/no-no-no" );
            }
            catch ( WebException ex )
            {
               lblResult.Content = ex.Message;
            }
         }
      }

      private async void OnThrowUnhandledClick( object sender, RoutedEventArgs e )
      {
         Task t = Task.Factory.StartNew( async () =>
            {
               using ( WebClient client = new WebClient() )
               {
                  string data = await client.DownloadStringTaskAsync( "http://does.not.exist/no-no-no" );
               }
            } );

         // Give the task time to complete and then trigger garbage collection (for example purposes only).
         Thread.Sleep( 5000 );

         t = null;
         GC.WaitForPendingFinalizers();
         GC.Collect();
         lblResult.Content = "Execution complete.";
      }

      private void OnInstallHandlerClick( object sender, RoutedEventArgs e )
      {
         // Subscribe to the TaskScheduler.UnobservedTaskException event and define an event handler.
         TaskScheduler.UnobservedTaskException += ( object s, UnobservedTaskExceptionEventArgs ute ) =>
            {
               foreach( Exception exception in ute.Exception.InnerExceptions )
               {
                  MessageBox.Show( string.Format( "An exception occurred: {0}", exception.Message ) );
               }
               
               // Set the exception status to Observed.
               ute.SetObserved();
            };
      }

      private void OnClearClick( object sender, RoutedEventArgs e )
      {
         lblResult.Content = null;
      }
   }
}
