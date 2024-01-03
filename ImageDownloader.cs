using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectimage
{
    public class ImageDownloader
    {
        public byte[] DownloadImage(string link)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    var uri = new Uri(link);

                    Console.WriteLine($"Downloading image from: {uri.AbsoluteUri}");
                    byte[] imageData = client.GetByteArrayAsync(uri).Result;

                    Console.WriteLine("Download successful.");
                    return imageData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading image: {ex.Message}");
                return null;
            }
        }
    }
}