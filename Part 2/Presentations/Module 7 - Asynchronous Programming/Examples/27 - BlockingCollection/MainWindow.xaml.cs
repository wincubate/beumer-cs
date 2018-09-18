using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Wincubate.Module07.Slide26
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      BlockingCollection<int> _bc;
      Random _random;

      public MainWindow()
      {
         InitializeComponent();

         _bc = new BlockingCollection<int>(5);
         _random = new Random();
      }

      async private void OnAdd(object sender, RoutedEventArgs e)
      {
         int n = _random.Next(100);
         lst.Items.Add($"Attempting to add {n}...");

         try
         {
            await Task.Run(() =>
            {
               _bc.Add(n);
            });
            lst.Items.Add($"Successfully added {n}");
         }
         catch (InvalidOperationException)
         {
            lst.Items.Add("Attempting Add to a completed collection");
         }

      }

      private void btnComplete_Click(object sender, RoutedEventArgs e)
      {
         lst.Items.Add("Completing adding");
         _bc.CompleteAdding();
      }

      async private void btnTake_Click(object sender, RoutedEventArgs e)
      {
         lst.Items.Add("Attempting take...");

         try
         {
            lst.Items.Add(
               $"Successfully took {await Task.Run<int>(() => _bc.Take())}"
            );
         }
         catch (InvalidOperationException)
         {
            lst.Items.Add("Attempting Take from a completed collection");
         }
      }
   }
}
