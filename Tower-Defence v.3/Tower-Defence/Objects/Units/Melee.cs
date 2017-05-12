using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Melee : Unit
    {
        public Melee(bool enemy, int X, int Y)
        {
            map.field[X, Y].obj = this;
            map.field[X, Y].pass = false;
            this.X = X;
            this.Y = Y;
            this.enemy = enemy;
            alive = true;
            hp = 12;
            damage = 4;
            siegeDamage = 2;
            range = 1;//Одна клетка, будет атаковать только юнитов, стоящих в соседних клетках
        }
    }
}
