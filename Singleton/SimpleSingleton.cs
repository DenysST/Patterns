#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace Singleton;

public class SimpleSingleton {
    private static SimpleSingleton? _instance;
    
    private SimpleSingleton() {}

    public static SimpleSingleton? Instance
    {
        get { return _instance ??= new SimpleSingleton(); }
    }
}