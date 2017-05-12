using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Range : Unit
    {
        public Range(bool enemy, int X, int Y)
        {
            map.field[X, Y].obj = this;
            map.field[X, Y].pass = false;
            this.X = X;
            this.Y = Y;
            this.enemy = enemy;
            alive = true;
            hp = 10;
            damage = 3;
            siegeDamage = 1;
            range = 3;//Три клетки, будет атаковать юнитов, стоящих через две/одну/в соседней клетке.
        }
    }
}
