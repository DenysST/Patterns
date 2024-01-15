namespace Iterator;

public interface IChannelCollection {
    void AddChannel(Channel channel);
    void RemoveChannel(Channel channel);
    IChannelIterator Iterator(ChannelTypeEnum typeEnum);
}