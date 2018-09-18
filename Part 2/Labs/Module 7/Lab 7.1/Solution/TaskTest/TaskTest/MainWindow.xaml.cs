using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;

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

      async Task<int> ComputeLengthSumAsync()
      {
         var t1 = CreateFetchTaskAsync( "http://www.jp.dk/" );
         var t2 = CreateFetchTaskAsync( "http://www.bt.dk/" );
         var t3 = CreateFetchTaskAsync( "http://www.eb.dk/" );

         string[] results = await Task.WhenAll( t1, t2, t3 );

         return results.Sum( s => s.Length );
      }

      Task<string> CreateFetchTaskAsync( string url )
      {
         using ( WebClient client = new WebClient() )
         {
            return client.DownloadStringTaskAsync( url );
         }
      }

      async void OnComputeClick( object sender, RoutedEventArgs e )
      {
         tbResult.Text = "The sum of the document lengths are " + await ComputeLengthSumAsync();
      }
   }
}
