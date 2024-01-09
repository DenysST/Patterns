namespace Singleton;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance;
    private static readonly object LockObject = new();
    
    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton? Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (LockObject) {
                    _instance ??= new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }
}