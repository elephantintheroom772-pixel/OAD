using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 90;
        Strength = 11;
        Intelligence = 7;
        Agility = 18;
        Defense = 5;
        CriticalChance = 25;
    }

    public override void UseSpecial()
    {
        int damage = Strength * 5;
        Console.WriteLine($"{Name} uses Rain of Arrows and deals {damage} damage!");
    }
}
