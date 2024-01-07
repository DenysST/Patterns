namespace Observer; 

public class Subject : ISubject {
    private readonly List<IObserver> _observers = new();

    public void RegisterObserver(IObserver observer) {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer) {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string message) {
        foreach (var observer in _observers) {
            observer.Update(message);
        }
    }
}