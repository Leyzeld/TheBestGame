using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    public class Damage
    {
        private int result_damage;
        private bool crit;
        public Damage(int _result_damage, bool _crit)
        {
            result_damage = _result_damage;
            crit = _crit;
        }
        public int Result_damage
        {
            get { return result_damage; }
        }
        public bool Crit
        {
            get { return crit; }
        }
    }

    public class Weapon : Item
    {
        private int id;
        private Bitmap skin;
        private string name;
        private int min_damage;
        private int max_damage;
        private int crit_damage_chance;
        private double crit_damage_multiplier = 2;
        private int price;

        Random rnd = new Random();

        public Weapon()
        {
            id = 1;
            name = "test sword";
            min_damage = 10;
            max_damage = 20;
            crit_damage_chance = 20;
            price = 111;
        }
        public Weapon(int _id,
                      string _name,
                      int _min_damage,
                      int _max_damage,
                      int _crit_damage_chance)
        {
            id = _id;
            name = _name;
            min_damage = _min_damage;
            max_damage = _max_damage;
            crit_damage_chance = _crit_damage_chance;
        }

        public Weapon(Weapon _weapon)
        {
            id = _weapon.Id;
            name = _weapon.Name;
            min_damage = _weapon.MinDamage;
            max_damage = _weapon.MaxDamage;
            crit_damage_chance = _weapon.CritChance;
            crit_damage_multiplier = _weapon.CritMultiplier;
        }

        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }

        public int MinDamage
        {
            get { return min_damage; }
        }

        public int MaxDamage
        {
            get { return max_damage; }
        }

        public int CritChance
        {
            get { return crit_damage_chance; }
        }

        public double CritMultiplier
        {
            get { return crit_damage_multiplier; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public Damage GetDamage()
        {
            int damage = GetNumberFromInterval(min_damage, max_damage);
            bool crit = IsCrit(crit_damage_chance);
            int result_damage = CalculateResultDamage(damage, crit, crit_damage_multiplier);
            return new Damage(result_damage, crit);
        }

        private int GetNumberFromInterval(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        private bool IsCrit(int crit_chance)
        {

            int rnd_num = rnd.Next(100 + 1);
            if (rnd_num <= crit_chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculateResultDamage(int damage, bool crit, double crit_multiplier)
        {
            if (crit)
            {
                double result_damage = damage * crit_multiplier;
                return (int)result_damage;
            }
            else
            {
                return damage;
            }
        }
    }
}
