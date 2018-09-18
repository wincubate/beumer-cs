using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide17
{
   class Program
   {
      static List<string> Urls;

      static void Main( string[] args )
      {
         #region URLs
         
         Urls = new List<string>
         {
            "http://upload.wikimedia.org/wikipedia/commons/7/7b/Anders_Hejlsberg_at_PDC2008.jpg",
            "http://upload.wikimedia.org/wikipedia/commons/7/7b/Anders_Hejlsberg_at_PDC2008.jpg",
            "http://upload.wikimedia.org/wikipedia/commons/7/7b/Anders_Hejlsberg_at_PDC2008.jpg",
            "http://www.brezovits.at/Bilder/C_Masterminds/Bjarne.jpg",
            "http://www.brezovits.at/Bilder/C_Masterminds/Bjarne.jpg",
            "http://www.brezovits.at/Bilder/C_Masterminds/Bjarne.jpg",
            "http://24.media.tumblr.com/ac1aecef3c3423ab5daab97f97acf03a/tumblr_mfutwr2OzL1qfrov6o1_1280.jpg",
            "http://24.media.tumblr.com/ac1aecef3c3423ab5daab97f97acf03a/tumblr_mfutwr2OzL1qfrov6o1_1280.jpg",
            "http://24.media.tumblr.com/ac1aecef3c3423ab5daab97f97acf03a/tumblr_mfutwr2OzL1qfrov6o1_1280.jpg",
            "http://24.media.tumblr.com/7fc908245d955758f41f17bee04718a7/tumblr_mfutwr2OzL1qfrov6o3_1280.jpg",
            "http://24.media.tumblr.com/7fc908245d955758f41f17bee04718a7/tumblr_mfutwr2OzL1qfrov6o3_1280.jpg",
            "http://24.media.tumblr.com/7fc908245d955758f41f17bee04718a7/tumblr_mfutwr2OzL1qfrov6o3_1280.jpg",
            "http://www.microsoft.com/global/en-us/news/publishingimages/press/2013/01-22SurfaceTypecover_Page.jpg",
            "http://www.microsoft.com/global/en-us/news/publishingimages/press/2013/01-22SurfaceTypecover_Page.jpg",
            "http://www.microsoft.com/global/en-us/news/publishingimages/press/2013/01-22SurfaceTypecover_Page.jpg",
            "http://farm6.staticflickr.com/5022/5672872595_0ed6e6fc47_o.jpg",
            "http://farm6.staticflickr.com/5022/5672872595_0ed6e6fc47_o.jpg",
            "http://farm6.staticflickr.com/5022/5672872595_0ed6e6fc47_o.jpg",
            "http://farm7.staticflickr.com/6173/6204382682_e8b4afc795_b.jpg",
            "http://farm7.staticflickr.com/6173/6204382682_e8b4afc795_b.jpg",
            "http://farm7.staticflickr.com/6173/6204382682_e8b4afc795_b.jpg"
         };

         #endregion

         Console.WriteLine( "Press ENTER to start downloading files." );
         Console.ReadLine();

         Console.WriteLine( $"Starting download at {DateTime.Now.ToLongTimeString()}" );
         int counter = 0;

         foreach ( string url in Urls )
         {
            string fileName = $"C:\\Tmp\\Test\\{counter.ToString()}.{System.IO.Path.GetExtension(url)}";
            FetchImage( url, fileName );

            counter++;
         }

         // Press ENTER to terminate
         Console.ReadLine();
      }

      static void FetchImage( string url, string localFileName )
      {
         using ( WebClient client = new WebClient() )
         {
            client.DownloadFile( url, localFileName );

            Console.WriteLine("Download of \"{localFileName}\" completed at {DateTime.Now.ToLongTimeString()}" );
         }
      }
   }
}
