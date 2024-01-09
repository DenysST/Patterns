namespace FactoryMethod;

public class PayPalPayment : IPayment {
    public void Pay(double amount) {
        Console.WriteLine($"Successfully paid ${amount} using PayPal");
    }
}