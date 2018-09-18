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

namespace HandlingTasks
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

      private void HeavyWork()
      {
         Random r = new Random();
         Thread.Sleep( TimeSpan.FromSeconds( 10 * r.NextDouble() ) ); // <----- "Hard" work  ;-)
      }

      async private void OnClick( object sender, RoutedEventArgs e )
      {
         button.IsEnabled = false;

         // TODO 1: Run three HeavyWork methods simultaneously
         List<Task> tasks = new List<Task>();
         for ( int i = 0 ; i < 3 ; i++ )
         {
            tasks.Add( Task.Run( () => HeavyWork() ) ); 
         }

         // Indicate start of tasks
         textBlock.Text = "Tasks are running...";

         // TODO 2: In case one or more HeavyWork tasks are still running after 7 seconds,
         //         update the UI to reflect this
         Task all = Task.WhenAll( tasks );
         Task delay = Task.Delay( 7000 );

         Task finished = await Task.WhenAny( all, delay );
         if ( finished == delay )
         {
            // Delay task was the first one to finish =>
            // "all" task is still running =>
            // one or more tasks must still be running
            textBlock.Text = "Some tasks are still running...";
         }

         // TODO 3: Update UI to reflect completion of all tasks
         await all;
         textBlock.Text = "All tasks are completed";

         button.IsEnabled = true;
      }
   }
}
