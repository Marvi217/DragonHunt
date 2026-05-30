using System;
using System.Windows.Forms;
using DragonHuntLib;

namespace DragonHunt
{
    public partial class MonsterPanel : UserControl
    {
        private Dragon _dragon;

        public MonsterPanel()
        {
            InitializeComponent();
        }

        public void Bind(Dragon d)
        {
            _dragon = d;
            Refresh();
        }

        public new void Refresh()
        {
            if (_dragon == null) return;
            lblName.Text = _dragon.Name;
            lblLevel.Text = $"Lvl {_dragon.Level}";
            pbHp.Maximum = Math.Max(1, _dragon.MaxHealth);
            pbHp.Value = Math.Max(0, Math.Min(_dragon.CurrentHealth, _dragon.MaxHealth));
            lblHp.Text = $"HP: {_dragon.CurrentHealth}/{_dragon.MaxHealth}";
        }
    }
}
