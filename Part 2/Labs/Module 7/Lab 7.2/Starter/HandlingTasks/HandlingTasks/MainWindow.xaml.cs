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

      private void OnClick( object sender, RoutedEventArgs e )
      {
         button.IsEnabled = false;

         // TODO 1: Run three HeavyWork methods simultaneously
         // ...

         // Indicate start of tasks
         textBlock.Text = "Tasks are running...";

         // TODO 2: In case one or more HeavyWork tasks are still running after 7 seconds,
         //         update the UI to reflect this
         // ...

         // TODO 3: Update UI to reflect completion of all tasks
         // ...

         button.IsEnabled = true;
      }
   }
}
