namespace Strategy; 

public interface IDeliveryStrategy {
    double CalculateCost(double price);
}

public class LandDeliveryStrategy : IDeliveryStrategy{
    public double CalculateCost(double price) {
        return price + 30;
    }
}

public class AirDeliveryStrategy : IDeliveryStrategy{
    public double CalculateCost(double price) {
        return price + 50;
    }
}

public class SeeDeliveryStrategy : IDeliveryStrategy{
    public double CalculateCost(double price) {
        return price + 10;
    }
}