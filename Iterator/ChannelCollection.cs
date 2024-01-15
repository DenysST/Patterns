namespace Iterator;

public class ChannelCollection : IChannelCollection {
    private readonly List<Channel> _channels = new ();
    
    public void AddChannel(Channel channel) {
        _channels.Add(channel);
    }

    public void RemoveChannel(Channel channel) {
        _channels.Remove(channel);
    }

    public IChannelIterator Iterator(ChannelTypeEnum typeEnum) {
        return new ChannelIterator(typeEnum, _channels);
    }
    
    private class ChannelIterator : IChannelIterator {
        private readonly ChannelTypeEnum _typeEnum;
        private readonly List<Channel> _channels;
        private int _position;
        
        public ChannelIterator(ChannelTypeEnum typeEnum, List<Channel> channels) {
            _typeEnum = typeEnum;
            _channels = channels;
        }
        
        public bool HasNext() {
            while (_position < _channels.Count) {
                Channel c = _channels[_position];
                if (c.GetType().Equals(_typeEnum) || _typeEnum.Equals(ChannelTypeEnum.All)) {
                    return true;
                }
                _position++;
            }
            return false;
        }

        public Channel Next() {
            Channel channel = _channels[_position];
            _position++;
            return channel;
        }
    }
}