using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestGame
{
    public class Inventory
    {
        List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public List<Item> Items
        {
            get { return items; }
            
        }

        public void AddItem(Item _item)
        {
            items.Add(_item);
        }

        public void RemoveItem(Item _item)
        {
            items.Remove(_item);
        }
    }
}
