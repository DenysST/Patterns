using Prototype;

internal class Program {
    public static void Main(string[] args) {
        var firstCharacter = new Warrior("first", 100, 200);
        var newCharacter = firstCharacter.Clone();
        newCharacter.Name = "new name";
        newCharacter.Health = 150;
        newCharacter.AttackPower = 100;
        
        Console.WriteLine(firstCharacter);
        Console.WriteLine(newCharacter);
    }
}