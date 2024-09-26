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
    public enum BodyPart { Head, Torso, Legs }
    public partial class FightForm : Form
    {
        Player player1;
        Character fighter1;
        BodyPart player1_attack_point = BodyPart.Head;
        BodyPart player1_defense_point = BodyPart.Head;

        Player player2;
        Character fighter2;
        BodyPart player2_attack_point = BodyPart.Head;
        BodyPart player2_defense_point = BodyPart.Head;

        int player1_max_hp;
        int player2_max_hp;

        Random rnd = new Random();

        health_bar.HealthBar healthBar1;
        health_bar.HealthBar healthBar2;
        public FightForm(Player _player1, Player _player2)
        {
            InitializeComponent();
            player1 = _player1;
            fighter1 = new Character(player1.Character);
            player2 = _player2;
            fighter2 = new Character(player2.Character);
            player1_max_hp = player1.Character.HealthPoints;
            player2_max_hp = player2.Character.HealthPoints;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            Player1NameLabel.Text = player1.Name;
            Player2NameLabel.Text = player2.Name;

            healthBar1 = new health_bar.HealthBar(healthPictureBox1,player1_max_hp);
            healthBar2 = new health_bar.HealthBar(healthPictureBox2, player2_max_hp);
            //Player1HPLabel.Text = "XP " + fighter1.HealthPoints + " / " + player1_max_hp;
            //Player2HPLabel.Text = "XP " + fighter2.HealthPoints + " / " + player2_max_hp;

            Player1DamageLabel.Text = "Урон " + fighter1.Weapon.MinDamage + " - " + fighter1.Weapon.MaxDamage;
            Player2DamageLabel.Text = "Урон " + fighter2.Weapon.MinDamage + " - " + fighter2.Weapon.MaxDamage;

            Player1DefenseLabel.Text = "Защита " + fighter1.Defense;
            Player2DefenseLabel.Text = "Защита " + fighter2.Defense;

            Player1CritChanceLabel.Text = "Шанс крита " + fighter1.Weapon.CritChance;
            Player2CritChanceLabel.Text = "Шанс крита " + fighter2.Weapon.CritChance;

            Player1CritMultLabel.Text = "Множитель крита " + fighter1.Weapon.CritMultiplier;
            Player2CritMultLabel.Text = "Множитель крита " + fighter2.Weapon.CritMultiplier;
        }

        public void UpdateHP()
        {
            //Player1HPLabel.Text = "XP " + fighter1.HealthPoints + " / " + player1_max_hp;
            //Player2HPLabel.Text = "XP " + fighter2.HealthPoints + " / " + player2_max_hp;
        }

        private void DefenseHeadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_defense_point = BodyPart.Head;
        }

        private void DefenseTorsoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_defense_point = BodyPart.Torso;
        }

        private void DefenseLegsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_defense_point = BodyPart.Legs;
        }

        private void AttackHeadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_attack_point = BodyPart.Head;
        }

        private void AttackTorsoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_attack_point = BodyPart.Torso;
        }

        private void AttackLegsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            player1_attack_point = BodyPart.Legs;
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            Damage player1_damage;
            Damage player2_damage;
            FightLogTextBox.Text = "";
            RandomizePlayer2Points();
            Player1StepLog();
            if(player1_attack_point == player2_defense_point)
            {
                FightLogTextBox.Text += "Удар отражен!\r\n\r\n";
            }
            else
            {
                player1_damage = fighter1.Attack();
                if(player1_damage.Result_damage <= fighter2.Defense)
                {
                    FightLogTextBox.Text += "Урон от удара: " + player1_damage.Result_damage + " Защита: " + fighter2.Defense + " Броня не пробита!\r\n\r\n";
                }
                else
                {
                    FightLogTextBox.Text += "Урон от удара = (урон)" + player1_damage.Result_damage + " - (защита)" + fighter2.Defense + " = " + (player1_damage.Result_damage - fighter2.Defense) + "\r\n";
                    FightLogTextBox.Text += player2.Name + " HP = " + fighter2.HealthPoints + " - " + (player1_damage.Result_damage - fighter2.Defense) + " = " + (fighter2.HealthPoints - (player1_damage.Result_damage - fighter2.Defense)) + "\r\n\r\n";
                    fighter2.TakeDamage(player1_damage);
                    healthBar2.ReduceValue(player1_damage.Result_damage - fighter2.Defense);
                    UpdateHP();
                }
            }
            Player2StepLog();
            if (player2_attack_point == player1_defense_point)
            {
                FightLogTextBox.Text += "Удар отражен!\r\n";
            }
            else
            {
                player2_damage = fighter2.Attack();
                if (player2_damage.Result_damage <= fighter1.Defense)
                {
                    FightLogTextBox.Text += "Урон от удара: " + player2_damage.Result_damage + " Защита: " + fighter1.Defense + " Броня не пробита!\r\n";
                }
                else
                {
                    FightLogTextBox.Text += "Урон от удара = (урон)" + player2_damage.Result_damage + " - (защита)" + fighter1.Defense + " = " + (player2_damage.Result_damage - fighter1.Defense) + "\r\n";
                    FightLogTextBox.Text += player1.Name + " HP = " + fighter1.HealthPoints + " - " + (player2_damage.Result_damage - fighter1.Defense) + " = " + (fighter1.HealthPoints - (player2_damage.Result_damage - fighter1.Defense)) + "\r\n";
                    fighter1.TakeDamage(player2_damage);
                    healthBar1.ReduceValue(player2_damage.Result_damage - fighter1.Defense);
                    UpdateHP();
                }
            }
        }

        private void Player1StepLog()
        {
            switch(player1_attack_point)
            {
                case BodyPart.Head:
                    FightLogTextBox.Text += player1.Name + " ударяет в голову\r\n";
                    break;
                case BodyPart.Torso:
                    FightLogTextBox.Text += player1.Name + " ударяет в тело\r\n";
                    break;
                case BodyPart.Legs:
                    FightLogTextBox.Text += player1.Name + " ударяет в ноги\r\n";
                    break;
            }

            switch(player2_defense_point)
            {
                case BodyPart.Head:
                    FightLogTextBox.Text += player2.Name + " защищает голову\r\n";
                    break;
                case BodyPart.Torso:
                    FightLogTextBox.Text += player2.Name + " защищает тело\r\n";
                    break;
                case BodyPart.Legs:
                    FightLogTextBox.Text += player2.Name + " защищает ноги\r\n";
                    break;
            }
                
        }

        private void Player2StepLog()
        {
            switch (player2_attack_point)
            {
                case BodyPart.Head:
                    FightLogTextBox.Text += player2.Name + " ударяет в голову\r\n";
                    break;
                case BodyPart.Torso:
                    FightLogTextBox.Text += player2.Name + " ударяет в тело\r\n";
                    break;
                case BodyPart.Legs:
                    FightLogTextBox.Text += player2.Name + " ударяет в ноги\r\n";
                    break;
            }

            switch (player1_defense_point)
            {
                case BodyPart.Head:
                    FightLogTextBox.Text += player1.Name + " защищает голову\r\n";
                    break;
                case BodyPart.Torso:
                    FightLogTextBox.Text += player1.Name + " защищает тело\r\n";
                    break;
                case BodyPart.Legs:
                    FightLogTextBox.Text += player1.Name + " защищает ноги\r\n";
                    break;
            }

        }

        private void RandomizePlayer2Points()
        {
            player2_attack_point = (BodyPart)rnd.Next(0, 3);
            player2_defense_point = (BodyPart)rnd.Next(0, 3);
        }
    }
}
