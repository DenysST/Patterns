namespace Proxy; 

public interface IImageLoader {
    byte[] LoadImageByUrl(string url);
}