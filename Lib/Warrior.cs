namespace DragonHuntLib
{
    public class Warrior : Character
    {
        public int AttacksPerRound { get; set; }

        public Warrior(string name)
            : base(name, 1, 0, 16, 10, 6, 40, 40, 8, 4)
        {
            AttacksPerRound = 2;
        }

        public override int Damage => (BaseDamage + Strength / 2) * AttacksPerRound;

        public override void LevelUp()
        {
            base.LevelUp();
            MaxHealth += 12;
            CurrentHealth = MaxHealth;
            Strength += 2;
            Dexterity += 1;
            BaseDamage += 1;
            if (Level % 4 == 0)
                AttacksPerRound++;
        }

        public override string ToString() =>
            base.ToString() + $" | Ataki/rundę: {AttacksPerRound}";
    }
}
