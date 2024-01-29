
using Facade;

internal class Program {
    public static void Main(string[] args) {
        SmartHomeFacade facade = new();
        facade.StartEveningRoutine();
        facade.EndEveningRoutine();
    }
}