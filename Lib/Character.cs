using System;

namespace DragonHuntLib
{
    public abstract class Character : IComparable<Character>
    {
        protected static readonly Random Rng = new Random();

        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int BaseDamage { get; set; }
        public int DamageResistance { get; set; }

        protected Character() { }

        protected Character(string name, int level, int experiencePoints,
                            int strength, int dexterity, int intelligence,
                            int currentHealth, int maxHealth,
                            int baseDamage, int damageResistance)
        {
            Name = name;
            Level = level;
            ExperiencePoints = experiencePoints;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            BaseDamage = baseDamage;
            DamageResistance = damageResistance;
        }

        public virtual int Damage => BaseDamage;

        public bool IsDead => CurrentHealth == 0;

        public void Arm(int bonus) => BaseDamage += bonus;

        public void PutOnArmor(int bonus) => DamageResistance += bonus;

        public virtual void TakeDamage(int damage)
        {
            int effective = Math.Max(0, damage - DamageResistance);
            CurrentHealth = Math.Max(0, CurrentHealth - effective);
        }

        public virtual void LevelUp()
        {
            Level++;
            CurrentHealth = MaxHealth;
        }

        public void GainExperience(int xp)
        {
            ExperiencePoints += xp;
            while (ExperiencePoints >= 100 * Level)
                LevelUp();
        }

        public int CompareTo(Character other)
        {
            if (other == null) return 1;
            return Level.CompareTo(other.Level);
        }

        public override string ToString() =>
            $"[{GetType().Name}] {Name} | Lvl {Level} | HP {CurrentHealth}/{MaxHealth} | " +
            $"STR {Strength} DEX {Dexterity} INT {Intelligence} | " +
            $"DMG {Damage} RES {DamageResistance} | XP {ExperiencePoints}";
    }
}
