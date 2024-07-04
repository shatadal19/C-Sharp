using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name = "Shatadal";
        private int health = 10;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
}
