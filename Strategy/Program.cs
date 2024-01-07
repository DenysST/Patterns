// See https://aka.ms/new-console-template for more information

using Strategy;

internal class Program {
    public static void Main(string[] args) {
        double productPrice = 100.00;
        DeliveryService airDeliveryService = new DeliveryService(new AirDeliveryStrategy());
        Console.WriteLine("Price with air delivery: " +  airDeliveryService.CalculateDeliveryConst(productPrice));
        
        DeliveryService landDeliveryService = new DeliveryService(new LandDeliveryStrategy());
        Console.WriteLine("Price with air delivery: " +  landDeliveryService.CalculateDeliveryConst(productPrice));
        
        DeliveryService seeDeliveryService = new DeliveryService(new SeeDeliveryStrategy());
        Console.WriteLine("Price with air delivery: " +  seeDeliveryService.CalculateDeliveryConst(productPrice));
    }
}