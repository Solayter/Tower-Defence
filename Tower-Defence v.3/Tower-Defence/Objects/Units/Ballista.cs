using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Ballista : Unit
    {
        public Ballista(bool enemy, int X, int Y)
        {
            map.field[X, Y].obj = this;
            map.field[X, Y].pass = false;
            this.X = X;
            this.Y = Y;
            this.enemy = enemy;
            alive = true;
            hp = 8;
            siegeDamage = 5;
            damage = 2;
            range = 3;//Три клетки, будет атаковать юнитов, стоящих через две/одну/в соседней клетке.
        }
    }
}
