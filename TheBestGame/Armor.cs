using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//test
namespace TheBestGame
{
    class Armor
    {
        //private int id;
        //private Bitmap skin;
        private string name;
        private int defense;

        public Armor()
        {
            name = "test armor";
            defense = 20;
        }
        public Armor(string _name, int _defense)
        {
            name = _name;
            defense = _defense;
        }
        public string GetName()
        {
            return name;
        }

        public int GetDefense()
        {
            return defense;
        }
        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetDefense(int _defense)
        {
            defense = _defense;
        }
    }

    class Helmet : Armor
    {

    }
    class Torso : Armor
    {

    }
    class Leggings : Armor
    {

    }
}
