using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DragonHuntLib;

namespace DragonHunt
{
    public partial class Form1 : Form
    {
        private Warrior _warrior;
        private Archer _archer;
        private Wizard _wizard;
        private Dragon _dragon;
        private List<Character> _party;
        private int _potions;

        private readonly CharacterPanel _pWarrior = new CharacterPanel();
        private readonly CharacterPanel _pArcher = new CharacterPanel();
        private readonly CharacterPanel _pWizard = new CharacterPanel();
        private readonly MonsterPanel _pMonster = new MonsterPanel();
        private readonly Label lblPotions = new Label();
        private readonly Button btnRound = new Button();
        private readonly Button btnSimulate = new Button();
        private readonly Button btnReset = new Button();
        private readonly Label lblResult = new Label();

        public Form1()
        {
            InitializeComponent();
            BuildUI();
            InitBattle();
        }

        private void BuildUI()
        {
            lblPotions.Location = new Point(10, 8);
            lblPotions.Size = new Size(200, 20);

            _pWarrior.Location = new Point(10, 30);
            _pArcher.Location = new Point(310, 30);
            _pWizard.Location = new Point(610, 30);

            _pWarrior.PotionClicked += (s, e) => UsePotion(_warrior, _pWarrior);
            _pArcher.PotionClicked += (s, e) => UsePotion(_archer, _pArcher);
            _pWizard.PotionClicked += (s, e) => UsePotion(_wizard, _pWizard);

            _pWarrior.StateChanged += (s, e) => RefreshAll();
            _pArcher.StateChanged += (s, e) => RefreshAll();
            _pWizard.StateChanged += (s, e) => RefreshAll();

            _pMonster.Location = new Point(10, 215);

            btnRound.Location = new Point(10, 368);
            btnRound.Size = new Size(130, 28);
            btnRound.Text = "Następna runda";
            btnRound.Click += (s, e) => PlayRound();

            btnSimulate.Location = new Point(150, 368);
            btnSimulate.Size = new Size(165, 28);
            btnSimulate.Text = "Symuluj całą bitwę";
            btnSimulate.Click += (s, e) => SimulateBattle();

            btnReset.Location = new Point(325, 368);
            btnReset.Size = new Size(80, 28);
            btnReset.Text = "Reset";
            btnReset.Click += (s, e) => InitBattle();

            lblResult.Location = new Point(415, 371);
            lblResult.Size = new Size(510, 25);
            lblResult.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            Controls.AddRange(new Control[] {
                lblPotions, _pWarrior, _pArcher, _pWizard, _pMonster,
                btnRound, btnSimulate, btnReset, lblResult
            });
        }

        private void InitBattle()
        {
            _potions = 3;
            lblPotions.Text = "Mikstury: 3";
            lblResult.Text = "";
            btnRound.Enabled = true;
            btnSimulate.Enabled = true;

            _warrior = new Warrior("Thorin");
            _archer = new Archer("Legolas");
            _wizard = new Wizard("Gandalf");
            _party = new List<Character> { _warrior, _archer, _wizard };

            _dragon = new Dragon
            {
                Name = "Smaug",
                Level = 10,
                Strength = 50,
                Dexterity = 8,
                Intelligence = 20,
                CurrentHealth = 300,
                MaxHealth = 300,
                BaseDamage = 25,
                DamageResistance = 8,
                ExperienceReward = 1500
            };
            WireDragonEvent();

            _pWarrior.Bind(_warrior);
            _pArcher.Bind(_archer);
            _pWizard.Bind(_wizard);
            _pMonster.Bind(_dragon);

            _pWarrior.EnablePotion(true);
            _pArcher.EnablePotion(true);
            _pWizard.EnablePotion(true);
        }

        private void WireDragonEvent()
        {
            _dragon.FireBreathed += intensity =>
            {
                foreach (var hero in _party)
                    if (!hero.IsDead)
                        hero.TakeDamage(intensity);
            };
        }

        private void UsePotion(Character hero, CharacterPanel panel)
        {
            if (_potions <= 0 || hero.IsDead) return;
            hero.DrinkFullHealingPotion();
            _potions--;
            lblPotions.Text = $"Mikstury: {_potions}";
            if (_potions == 0)
            {
                _pWarrior.EnablePotion(false);
                _pArcher.EnablePotion(false);
                _pWizard.EnablePotion(false);
            }
            panel.Refresh();
        }

        private static void BattleRound(List<Character> party, Dragon dragon)
        {
            foreach (var hero in party)
                if (!hero.IsDead)
                    dragon.TakeDamage(hero.Damage);

            if (!dragon.IsDead)
                dragon.BreatheFire();
        }

        private void PlayRound()
        {
            BattleRound(_party, _dragon);
            RefreshAll();
            CheckBattleEnd();
        }

        private void SimulateBattle()
        {
            while (!_dragon.IsDead && _party.Any(h => !h.IsDead))
                BattleRound(_party, _dragon);

            RefreshAll();
            CheckBattleEnd();
        }

        private void RefreshAll()
        {
            _pWarrior.Refresh();
            _pArcher.Refresh();
            _pWizard.Refresh();
            _pMonster.Refresh();
        }

        private void CheckBattleEnd()
        {
            if (_dragon.IsDead)
            {
                var survivors = _party.Where(h => !h.IsDead).ToList();
                if (survivors.Count > 0)
                {
                    int xpEach = _dragon.ExperienceReward / survivors.Count;
                    foreach (var hero in survivors)
                        hero.GainExperience(xpEach);
                }
                lblResult.Text = "Drużyna zwyciężyła!";
                btnRound.Enabled = false;
                btnSimulate.Enabled = false;
                RefreshAll();
            }
            else if (_party.All(h => h.IsDead))
            {
                lblResult.Text = "Smok was pożarł!";
                btnRound.Enabled = false;
                btnSimulate.Enabled = false;
            }
        }
    }
}
