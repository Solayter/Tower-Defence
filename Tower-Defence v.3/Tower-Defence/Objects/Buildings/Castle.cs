using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Castle : Building
    {
        public Castle(bool enemy, int X, int Y)
        {
            map.field[X, Y].obj = this;
            map.field[X, Y].pass = false;
            this.enemy = enemy;
            this.X = X;
            this.Y = Y;
            alive = true;
            hp = 150;
            damage = 5;
            range = 4;
        }
    }
}
