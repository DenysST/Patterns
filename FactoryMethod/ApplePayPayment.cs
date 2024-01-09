namespace FactoryMethod;

public class ApplePayPayment : IPayment {
    public void Pay(double amount) {
        Console.WriteLine($"Successfully paid ${amount} using ApplePay");
    }
}