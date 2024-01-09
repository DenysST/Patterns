namespace Adapter;

public class CardReader : IUsb {
    private readonly MemoryCard _memoryCard;

    public CardReader(MemoryCard memoryCard) {
        _memoryCard = memoryCard;
    }

    public void ConnectWithUsbCable() {
        _memoryCard.InsertIntoComputer();
        _memoryCard.CopyData();
    }
}