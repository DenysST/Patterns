
using AbstractFactory.Factories;
using AbstractFactory.Factories.Animals;
using AbstractFactory.Factories.Vehicles;

internal class Program {
    public static void Main(string[] args) {
        IAbstractFactory<object> abstractFactory = FactoryProvider.GetFactory(FactoryType.Animal);
        IAnimal animal = (IAnimal) abstractFactory.Create("Dog");
        
        abstractFactory = FactoryProvider.GetFactory(FactoryType.Vehicle);
        IVehicle vehicle = (IVehicle) abstractFactory.Create("Car");
        
        animal.MakeSound();
        vehicle.GetType();
    }
}