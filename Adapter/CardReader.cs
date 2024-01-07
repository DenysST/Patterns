#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

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