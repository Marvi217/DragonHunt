using DragonHuntLib;

namespace DragonHunt
{
    public static class CharacterExtensions
    {
        public static void DrinkFullHealingPotion(this Character c) =>
            c.CurrentHealth = c.MaxHealth;

        public static void RegenerateMana(this Wizard w, int amount)
        {
            w.CurrentMana = Math.Min(w.MaxMana, w.CurrentMana + amount);
        }

        public static void Disarm(this Character c, int amount) =>
            c.BaseDamage = Math.Max(0, c.BaseDamage - amount);

        public static void TakeOffArmor(this Character c, int amount) =>
            c.DamageResistance = Math.Max(0, c.DamageResistance - amount);
    }
}
