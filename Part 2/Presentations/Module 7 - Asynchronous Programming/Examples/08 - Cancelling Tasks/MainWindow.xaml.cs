using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wincubate.Module07.Slide08
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      CancellationTokenSource _cts;
      Task _task;

      public MainWindow()
      {
         InitializeComponent();
      }

      private void OnGoClick( object sender, RoutedEventArgs e )
      {
         _cts = new CancellationTokenSource();
         CancellationToken token = _cts.Token;

         _task = Task.Factory.StartNew( () =>
            {
               for ( int i = 0 ; i < 1000 ; i++ )
               {
                  Console.WriteLine( i );
                  if ( token.IsCancellationRequested )
                  {
                     return;

                     //throw new OperationCanceledException( token );
                  }

                  //token.ThrowIfCancellationRequested();

                  Thread.Sleep( 10 );
               }
            }
            //, 
            //token
         );
      }

      private void OnCancelClick( object sender, RoutedEventArgs e )
      {
         _cts.Cancel();
      }

      private void OnStatusClick( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( _task.Status.ToString() );
      }
   }
}
