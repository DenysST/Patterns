namespace Adapter;

public class Program {
    public static void Main(string[] args) {
        IUsb cardReader = new CardReader(new MemoryCard());
        cardReader.ConnectWithUsbCable();
    }
}