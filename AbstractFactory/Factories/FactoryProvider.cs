using AbstractFactory.Factories.Animals;
using AbstractFactory.Factories.Vehicles;

namespace AbstractFactory.Factories;

public static class FactoryProvider
{
    public static IAbstractFactory<object> GetFactory(FactoryType type)
    {
        switch (type)
        {
            case FactoryType.Animal:
                return new AnimalFactory();
            case FactoryType.Vehicle:
                return new VehicleFactory();
            default:
                throw new InvalidOperationException("Not valid input type");
        }
    }
}