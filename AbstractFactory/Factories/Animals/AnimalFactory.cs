namespace AbstractFactory.Factories.Animals;

public class AnimalFactory : IAbstractFactory<IAnimal> {
    public IAnimal Create(string type) {
        switch (type.ToLower()) {
            case "dog":
                return new Dog();
            case "cat":
                return new Cat();
        }

        throw new Exception("Not valid input type");
    }
}