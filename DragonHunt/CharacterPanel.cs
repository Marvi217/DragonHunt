using System;
using System.Windows.Forms;
using DragonHuntLib;

namespace DragonHunt
{
    public partial class CharacterPanel : UserControl
    {
        private Character _character;

        public event EventHandler PotionClicked;
        public event EventHandler StateChanged;

        public CharacterPanel()
        {
            InitializeComponent();
            button1.Click += (s, e) => PotionClicked?.Invoke(this, EventArgs.Empty);
            btnAddXp.Click += (s, e) =>
            {
                if (_character != null && int.TryParse(txtXp.Text, out int xp) && xp > 0)
                {
                    _character.GainExperience(xp);
                    StateChanged?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public void Bind(Character c)
        {
            _character = c;
            bool isWizard = c is Wizard;
            lblMp.Visible = isWizard;
            pbMana.Visible = isWizard;
            Refresh();
        }

        public new void Refresh()
        {
            if (_character == null) return;
            lablName.Text = _character.Name;
            lblLevel.Text = $"Lvl {_character.Level}";
            pbHp.Maximum = Math.Max(1, _character.MaxHealth);
            pbHp.Value = Math.Max(0, Math.Min(_character.CurrentHealth, _character.MaxHealth));
            lblHp.Text = $"HP: {_character.CurrentHealth}/{_character.MaxHealth}";
            int threshold = 100 * _character.Level;
            pbXp.Maximum = Math.Max(1, threshold);
            pbXp.Value = Math.Max(0, Math.Min(_character.ExperiencePoints, threshold));
            lblXp.Text = $"XP: {_character.ExperiencePoints}/{threshold}";
            if (_character is Wizard w)
            {
                pbMana.Maximum = Math.Max(1, w.MaxMana);
                pbMana.Value = Math.Max(0, Math.Min(w.CurrentMana, w.MaxMana));
                lblMp.Text = $"MP: {w.CurrentMana}/{w.MaxMana}";
            }
        }

        public void EnablePotion(bool enabled) => button1.Enabled = enabled;
    }
}
