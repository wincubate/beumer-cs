using System;
using System.Collections.Generic;
using System.Diagnostics;
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

      private async void OnRunTaskGraph( object sender, RoutedEventArgs e )
      {
         #region Plain Tasks

         //Task t1 = new Task( () =>
         //{
         //   //throw new InvalidOperationException( "t1" );
         //   Trace.WriteLine( "t1 completed" );
         //}
         //);
         //Task t2 = t1.ContinueWith( t =>
         //{
         //   Trace.WriteLine( "t2 completed" );
         //}
         //);
         //Task t3 = t1.ContinueWith( t =>
         //{
         //   Trace.WriteLine( "t3 completed" );
         //}
         //);
         //Task t4 = t1.ContinueWith( t =>
         //{
         //   Trace.WriteLine( "t4 completed" );
         //}
         //);
         //Task t5 = Task
         //            .WhenAll( t3, t4 )
         //            .ContinueWith( t =>
         //            {
         //               Trace.WriteLine( "t5 completed" );
         //            }
         //);

         //t1.Start();
         //t5.Wait();

         //t1 = t2 = t3 = t4 = t5 = null;

         #endregion

         #region Tasks with results

         //Task<string> t1 = new Task<string>( () =>
         //{
         //   //throw new InvalidOperationException( "t1" );
         //   return "t1 completed! ";
         //}
         //);
         //Task<string> t2 = t1.ContinueWith( t =>
         //{
         //   //throw new InvalidOperationException( "t2" );
         //   return t.Result + "t2 completed! ";
         //}
         //);
         //Task<string> t3 = t2.ContinueWith( t =>
         //{
         //   //throw new InvalidOperationException( "t3" );
         //   return t.Result + "t3 completed! ";
         //}
         //);
         //Task<string> t4 = t1.ContinueWith( t =>
         //{
         //   //throw new InvalidOperationException( "t4" );
         //   return t.Result + "t4 completed! ";
         //}
         //);
         //Task<string> t5 = Task
         //            .WhenAll( t3, t4 )
         //            .ContinueWith( ts =>
         //            {
         //               //throw new InvalidOperationException( "t5" );
         //               //return "Done! ;-)";
         //               return string.Join( string.Empty, ts.Result ) + "t5 completed! ";
         //            }
         //            ,
         //            TaskContinuationOptions.NotOnFaulted
         //            );

         //t1.Start();
         
         //try
         //{
         //   MessageBox.Show( t5.Result );
         //   //MessageBox.Show( await t5 );

         //   t1 = t2 = t3 = t4 = t5 = null;
         //}
         //catch( AggregateException aggregate )
         //{
         //   MessageBox.Show( aggregate.Flatten().ToString() );
         //}
         //catch ( Exception exception )
         //{
         //   MessageBox.Show( exception.ToString() );
         //}

         #endregion
      }

      private void OnInstallHandlerClick( object sender, RoutedEventArgs e )
      {
         // Subscribe to the TaskScheduler.UnobservedTaskException event and define an event handler.
         TaskScheduler.UnobservedTaskException += ( object s, UnobservedTaskExceptionEventArgs ute ) =>
            {
               foreach( Exception exception in ute.Exception.Flatten().InnerExceptions )
               {
                  MessageBox.Show( string.Format( "An exception occurred: {0}", exception.Message ) );
               }
               
               // Set the exception status to Observed.
               ute.SetObserved();
            };
      }
   }
}
