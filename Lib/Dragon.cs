namespace DragonHuntLib
{
    public delegate void FireBreathHandler(int intensity);

    public class Dragon : Character
    {
        public int ExperienceReward { get; set; }

        public event FireBreathHandler FireBreathed;

        public override int Damage => BaseDamage + Strength / 2;

        public int BreatheFire()
        {
            int intensity = Level * 5 + Strength + Intelligence / 2;
            FireBreathed?.Invoke(intensity);
            return intensity;
        }

        public override string ToString() =>
            base.ToString() + $" | Nagroda XP: {ExperienceReward}";
    }
}
