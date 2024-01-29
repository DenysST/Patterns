namespace Decorator;

public class CharacterAttackDecorator : CharacterDecorator {
    public CharacterAttackDecorator(Character character, string name, int attack) : 
        base(character, name, attack, 0) {
    }
}