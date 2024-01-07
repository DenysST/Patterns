namespace AbstractFactory.Factories;

public interface IAbstractFactory<out T> {
    T Create(String type);
}