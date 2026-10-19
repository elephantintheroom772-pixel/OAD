using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Necromancer : Entity.Character
{
    public Necromancer(string name) : base(name, CharacterClass.Necromancer)
    {
        Health = 100;
        Strength = 6;
        Intelligence = 19;
        Agility = 9;
        Defense = 7;
        CriticalChance = 10;
    }

    public override void UseSpecial()
    {
        int damage = Intelligence * 4;
        Console.WriteLine($"{Name} uses Soul Drain and deals {damage} damage!");
    }
}
