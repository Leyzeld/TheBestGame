using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    public class Player
    {
        private string login;
        private string password;
        private string name;
        private Character character;
        private Inventory inventory;
        private int gold;
        private int donate_gold;
        private int pvp_stamina;
        private int pve_stamina;

        public Player()
        {
            login = "test_login";
            password = "test_password";
            name = "Player1";
            character = new Character();
            inventory = new Inventory();
            gold = 1000;
            donate_gold = 0;
            pvp_stamina = 10;
            pve_stamina = 10;
        }
        public Player(string _login, 
                      string _password, 
                      string _name, 
                      Character _character, 
                      Inventory _inventory, 
                      int _gold, 
                      int _donate_gold, 
                      int _pvp_stamina, 
                      int _pve_stamina)
        {
            login = _login;
            password = _password;
            name = _name;
            character = _character;
            inventory = _inventory;
            gold = _gold;
            donate_gold = _donate_gold;
            pvp_stamina = _pvp_stamina;
            pve_stamina = _pve_stamina;
        }

        public string Login
        {
            get{ return login; }
        }

        public string Password
        {
            get{ return password; }
        }

        public string Name
        {
            get { return name; }
        }

        public Character Character
        {
            get { return character; }
        }

        public Inventory Inventory
        {
            get { return inventory; }
        }

        public int Gold
        {
            get { return gold; }
        }

        public int Donate_gold
        {
            get { return donate_gold; }
        }

        public int Pvp_stamina
        {
            get { return pvp_stamina; }
        }

        public int Pve_stamina
        {
            get { return pve_stamina; }
        }
    }
}
