using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    public class Character
    {
        private int level;
        private int health_points;
        private Weapon weapon;
        private Helmet helmet;
        private Torso torso;
        private Leggings leggings;
        private Shield shield;
        private int defense;

        public Character()
        {
            level = 1;
            health_points = 100;
            weapon = new Weapon();
            helmet = new Helmet();
            torso = new Torso();
            leggings = new Leggings();
            shield = new Shield();
            CalculateDefense();
        }

        public Character(int _level,

                         int _health_points,
                         Weapon _weapon,
                         Helmet _helmet,
                         Torso _torso,
                         Leggings _leggings,
                         Shield _shield
                         )

        {
            level = _level;
            health_points = _health_points;
            weapon = _weapon;
            helmet = _helmet;
            torso = _torso;
            leggings = _leggings;
            shield = _shield;

            CalculateDefense();
        }

        public Character(Character _character)
        {
            level = _character.Level;
            health_points = _character.HealthPoints;
            weapon = new Weapon(_character.Weapon);
            helmet = new Helmet(_character.Helment);
            torso = new Torso(_character.Torso);
            leggings = new Leggings(_character.Leggings);
            shield = new Shield(_character.Shield);
            defense = _character.Defense;
        }

        public Damage Attack()
        {
            return weapon.GetDamage();
        }

        public void TakeDamage(Damage damage)
        {
            int dmg = damage.Result_damage;
            int result_damage = dmg - defense;
            if(result_damage <= 0)
            {
                return;
            }
            if(health_points - result_damage <= 0)
            {
                health_points = 0;
                return;
            }
            health_points -= result_damage;
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int HealthPoints
        {
            get { return health_points; }
            set { health_points = value; }
        }

        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Helmet Helment
        {
            get { return helmet; }
            set { helmet = value; }
        }

        public Torso Torso
        {
            get{ return torso; }
            set { torso = value; }
        }

        public Leggings Leggings
        {
            get{ return leggings; }
            set{ leggings = value; }
        }

        public int Defense
        {
            get { return defense; }
        }

        public Shield Shield
        {
            get{ return shield; }
            set { shield = value; }
        }

        private void CalculateDefense()
        {
            defense = helmet.Defense + torso.Defense + leggings.Defense;
        }
    }
}
