using System;

namespace DragonHuntLib
{
    public class Archer : Character
    {
        public int DodgeChance { get; set; }

        public Archer(string name)
            : base(name, 1, 0, 10, 16, 8, 28, 28, 6, 2)
        {
            DodgeChance = 20;
        }

        public override int Damage => BaseDamage + Dexterity / 2;

        public override void TakeDamage(int damage)
        {
            if (Rng.Next(100) < DodgeChance)
                return;
            base.TakeDamage(damage);
        }

        public override void LevelUp()
        {
            base.LevelUp();
            MaxHealth += 8;
            CurrentHealth = MaxHealth;
            Dexterity += 2;
            BaseDamage += 1;
            DodgeChance = Math.Min(60, DodgeChance + 3);
        }

        public override string ToString() =>
            base.ToString() + $" | Unik: {DodgeChance}%";
    }
}
