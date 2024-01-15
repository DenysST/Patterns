// See https://aka.ms/new-console-template for more information

using Iterator;

internal class Program {
    public static void Main(string[] args) {
        IChannelCollection channels = PopulateChannels();
        IChannelIterator baseIterator = channels.Iterator(ChannelTypeEnum.All);
        while (baseIterator.HasNext()) {
            Channel channel = baseIterator.Next();
            Console.WriteLine(channel.ToString());
        }
        
        Console.WriteLine("-------------------------");
        
        IChannelIterator englishIterator = channels.Iterator(ChannelTypeEnum.English);
        while (englishIterator.HasNext()) {
            Channel channel = englishIterator.Next();
            Console.WriteLine(channel.ToString());
        }
        
    }
    
    private static IChannelCollection PopulateChannels() {
        IChannelCollection channels = new ChannelCollection();
        channels.AddChannel(new Channel(98.5, ChannelTypeEnum.English));
        channels.AddChannel(new Channel(99.5, ChannelTypeEnum.Hindi));
        channels.AddChannel(new Channel(100.5, ChannelTypeEnum.French));
        channels.AddChannel(new Channel(101.5, ChannelTypeEnum.English));
        channels.AddChannel(new Channel(102.5, ChannelTypeEnum.Hindi));
        channels.AddChannel(new Channel(103.5, ChannelTypeEnum.French));
        channels.AddChannel(new Channel(104.5, ChannelTypeEnum.English));
        channels.AddChannel(new Channel(105.5, ChannelTypeEnum.Hindi));
        channels.AddChannel(new Channel(106.5, ChannelTypeEnum.French));
        return channels;
    }
}