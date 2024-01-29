namespace Decorator;

public class CharacterDefenseDecorator : CharacterDecorator {
    public CharacterDefenseDecorator(Character character, string name, int defense) : 
        base(character, name, 0, defense) {
    }
}