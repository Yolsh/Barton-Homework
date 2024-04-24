using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public abstract class Item
    {
        protected string Name;
        public abstract void UseItem(Warrior UsedOn);
        public string GetName()
        {
            return Name;
        }
    }
}
