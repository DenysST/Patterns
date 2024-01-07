using System.Net;

namespace Proxy; 

public class ImageLoader : IImageLoader {
    public byte[] LoadImageByUrl(string url) {
        Console.WriteLine("Downloading image from real service");
        
        using var client = new WebClient();
        return client.DownloadData(url);
    }
}