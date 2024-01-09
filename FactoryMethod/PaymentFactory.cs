#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace FactoryMethod;

public class PaymentFactory {
    public static IPayment Create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod) {
            case PaymentMethod.Card:
                return new CardPayment();
            case PaymentMethod.ApplePay:
                return new ApplePayPayment();
            case PaymentMethod.PayPal:
                return new PayPalPayment();
            default:
                throw new NotSupportedException("Unsupported payment method");
        }
    }
}