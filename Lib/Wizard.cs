namespace DragonHuntLib
{
    public class Wizard : Character
    {
        public int CurrentMana { get; set; }
        public int MaxMana { get; set; }

        public Wizard(string name)
            : base(name, 1, 0, 6, 8, 18, 20, 20, 4, 1)
        {
            MaxMana = 30;
            CurrentMana = 30;
        }

        public override int Damage => BaseDamage + Intelligence / 2;

        public override void LevelUp()
        {
            base.LevelUp();
            MaxHealth += 6;
            CurrentHealth = MaxHealth;
            MaxMana += 10;
            CurrentMana = MaxMana;
            Intelligence += 2;
            BaseDamage += 1;
        }

        public override string ToString() =>
            base.ToString() + $" | Mana: {CurrentMana}/{MaxMana}";
    }
}
