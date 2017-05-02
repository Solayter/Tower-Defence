using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Building:Entity //Здания
    {
        public void Action()
        {
            int m, n;
            if (target != null)
            {
                for (int i = X - range; i <= X + range; i++)
                    for (int j = Y - range; j <= Y + range; j++)
                    {
                        m = i;
                        n = j;

                        if (m < 0)
                            m = 0;
                        if (n < 0)
                            n = 0;
                        if (m > map.xX - 1)
                            m = map.xX - 1;
                        if (n > map.yY - 1)
                            n = map.yY - 1;
                        if (map.field[m, n].obj == target)
                        {
                            Attack();
                            return;
                        }
                    }
            }
        }
    }
    public class Tower:Building
    {
        public Tower(bool enemy, int X, int Y)
        {
            map.field[X, Y].obj = this;
            map.field[X, Y].pass = false;
            this.enemy = enemy;
            this.X = X;
            this.Y = Y;
            alive = true;
            hp = 50;
            damage = 5;
            range = 4;//Четыре клетки, будет атаковать юнитов, стоящих через три/две/одну/в соседней клетке.
        }
    }

    public class Castle:Building
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
