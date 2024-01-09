namespace Prototype;

public interface IPrototype<out T> {
    T Clone();
}