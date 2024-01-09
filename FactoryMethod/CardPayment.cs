namespace FactoryMethod;

public class CardPayment : IPayment {
    public void Pay(double amount) {
        Console.WriteLine($"Successfully paid ${amount} using Card");
    }
}