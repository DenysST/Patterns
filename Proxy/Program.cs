// See https://aka.ms/new-console-template for more information

using Proxy;

internal class Program {
    public static void Main(string[] args) {
        string imageUrl = "https://example.com/image.jpg";
        
        IImageLoader imageLoader = new ImageLoaderProxy(new ImageLoader());
        byte[] imageData = imageLoader.LoadImageByUrl(imageUrl);
        
        imageData = imageLoader.LoadImageByUrl(imageUrl);
    }
}

