namespace Proxy; 

public class ImageLoaderProxy : IImageLoader {
    private readonly ImageLoader _imageLoader;
    private readonly Dictionary<string, byte[]> _imageCache;

    public ImageLoaderProxy(ImageLoader imageLoader) {
        _imageLoader = imageLoader;
        _imageCache = new Dictionary<string, byte[]>();
    }

    public byte[] LoadImageByUrl(string url) {

        if (_imageCache.ContainsKey(url)) {
            Console.WriteLine("Loaded from cache");
            return _imageCache[url];
        }
        
        var imageByUrl = _imageLoader.LoadImageByUrl(url);
        _imageCache.Add(url, imageByUrl);
        return imageByUrl;
    }
}