namespace Strategy; 

public class DeliveryService {
    private readonly IDeliveryStrategy _deliveryStrategy;

    public DeliveryService(IDeliveryStrategy deliveryStrategy) {
        _deliveryStrategy = deliveryStrategy;
    }

    public double CalculateDeliveryConst(double price) {
        return _deliveryStrategy.CalculateCost(price);
    }
}