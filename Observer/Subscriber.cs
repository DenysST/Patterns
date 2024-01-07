namespace Observer; 

public class Subscriber : IObserver{
    public void Update(string message) {
        Console.WriteLine(message);
    }
}