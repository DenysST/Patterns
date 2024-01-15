namespace Iterator;

public interface IChannelIterator {
    bool HasNext();
    Channel Next();
}