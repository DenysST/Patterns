namespace Flyweight;

public class BookType {
    
    public BookType(string type, string distributor, string otherData) {
        Type = type;
        Distributor = distributor;
        OtherData = otherData;
    }

    public String Type { get; }
    public String Distributor { get; }
    public String OtherData { get; }

    public override string ToString() {
        return $"Type: {Type}, Distributor: {Distributor}, Other Data: {OtherData}";
    }
}