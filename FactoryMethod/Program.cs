// See https://aka.ms/new-console-template for more information

using FactoryMethod;

internal class Program {
    public static void Main(string[] args) {
        IPayment cardPayment = PaymentFactory.Create(PaymentMethod.Card);
        IPayment paypalPayment = PaymentFactory.Create(PaymentMethod.PayPal);
        IPayment applePayPayment = PaymentFactory.Create(PaymentMethod.ApplePay);

        cardPayment.Pay(1000.00);
        paypalPayment.Pay(2000.00);
        applePayPayment.Pay(3000.00);
    }
}