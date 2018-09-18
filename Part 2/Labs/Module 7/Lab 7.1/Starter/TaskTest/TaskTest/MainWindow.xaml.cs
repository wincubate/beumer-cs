using System;
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

namespace TaskTest
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

      // TODO
      Task<int> ComputeLengthSumAsync()
      {
         var t1 = CreateFetchTaskAsync( "http://www.jp.dk/" );
         var t2 = CreateFetchTaskAsync( "http://www.bt.dk/" );
         var t3 = CreateFetchTaskAsync( "http://www.eb.dk/" );

         // TODO
         throw new NotImplementedException();
      }

      Task<string> CreateFetchTaskAsync( string url )
      {
         // TODO
         throw new NotImplementedException();
      }

      void OnComputeClick( object sender, RoutedEventArgs e )
      {
         // TODO

         // tbResult.Text = ...;
      }
   }
}
