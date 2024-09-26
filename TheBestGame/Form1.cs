using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestGame
{
    public partial class Form1 : Form
    {
        private Player player1;
        private Player player2;
        public Form1()
        {
            InitializeComponent();
            InitializePlayer1();
            InitializePlayer2();
            InitializeGUI();
        }

        private void InitializePlayer1()
        {
            Weapon weapon = new Weapon(1, "King sword", 30, 40, 15);
            Helmet helmet = new Helmet("King helmet", 15);
            Torso torso = new Torso("King cuirass", 30);
            Leggings leggings = new Leggings("King boots", 10);
            Shield shield = new Shield("King shield");
            Character character = new Character(1, 200, weapon, helmet, torso, leggings, shield);
            player1 = new Player("test", "test", "BossOfThisKingdom", character, new Inventory(), 1000, 0, 10, 10);
        }
        private void InitializePlayer2()
        {
            Weapon weapon = new Weapon(1, "Slave sword", 30, 90, 15);
            Helmet helmet = new Helmet("Slave helmet", 5);
            Torso torso = new Torso("Slave cuirass", 5);
            Leggings leggings = new Leggings("Slave boots", 5);
            Shield shield = new Shield("Slave shield");
            Character character = new Character(1, 600, weapon, helmet, torso, leggings, shield);
            player2 = new Player("test", "test", "Bot", character, new Inventory(), 1000, 0, 10, 10);
        }


        //private void LogDamage(Damage damage)
        //{
        //    int dmg = damage.Result_damage;
        //    bool crit = damage.Crit;
        //    string record = dmg.ToString();
        //    if(crit)
        //    {
        //        record += "  крит!";
        //    }
        //    record += "\r\n";
        //    textBox1.Text = textBox1.Text + record;
        //}
        private void InitializeGUI()
        {
            InitializeWeaponPanel(player1.Character.Weapon);
            InitializeArmorPanel(player1.Character.Helment, HelmetNameLabel, HelmetDefenseLabel);
            InitializeArmorPanel(player1.Character.Torso, TorsoNameLabel, TorsoDefenceLabel);
            InitializeArmorPanel(player1.Character.Leggings, LeggingsNameLabel, LeggingsDefenseLabel);
            InitializeShieldPanel(player1.Character.Shield);
            NicknameLabel.Text = player1.Name;
            LevelLabel.Text = "Уровень: " + player1.Character.Level.ToString();
            GoldLabel.Text = "Золото: " + player1.Gold;
            DonateGoldLabel.Text = "Изумруды: " + player1.Donate_gold;
            XPLabel.Text = "XP 0 / 1000!!!";
            health_bar.HealthBar healthBar = new health_bar.HealthBar(HealthpictureBox, player1.Character.HealthPoints);
        }

        private void InitializeWeaponPanel(Weapon weapon)
        {
            WeaponNameLabel.Text = "Название: " + weapon.Name;
            WeaponDamageLabel.Text = "Урон: " + weapon.MinDamage.ToString() + " - " + weapon.MaxDamage.ToString();
            WeaponCritChanceLabel.Text = "Шанс крита: " + weapon.CritChance.ToString() + "%";
            WeaponMultLabel.Text = "Множитель крита: " + weapon.CritMultiplier.ToString();
        }

        private void InitializeArmorPanel(Armor armor, Label NameLabel, Label DefenseLabel)
        {
            NameLabel.Text = "Назване: " + armor.Name;
            DefenseLabel.Text = "Защита: " + armor.Defense.ToString();
        }

        private void InitializeShieldPanel(Shield shield)
        {
            ShieldNameLabel.Text = "Назание: " + shield.Name;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            FightForm fightForm = new FightForm(player1, player2);
            fightForm.Show();
        }
    }
}
