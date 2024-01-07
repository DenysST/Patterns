// See https://aka.ms/new-console-template for more information

using Observer;

internal class Program {
    public static void Main(string[] args) {
        ISubject subject = new Subject();
        IObserver subscriber = new Subscriber();
        
        subject.RegisterObserver(subscriber);
        
        subject.NotifyObservers("Message");
    }
}