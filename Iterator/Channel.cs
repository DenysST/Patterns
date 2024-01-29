namespace Iterator;

public class Channel {
    private readonly double _frequency;
    private readonly ChannelTypeEnum _typeEnum;

    public Channel(double frequency, ChannelTypeEnum typeEnum) {
        _typeEnum = typeEnum;
        _frequency = frequency;
    }

    public double GetFrequency() {
        return _frequency;
    }

    public new ChannelTypeEnum GetType() {
        return _typeEnum;
    }
    
    public override string ToString() {
        return $"Type: {_typeEnum}, Frequency: {_frequency}";
    }
    
}