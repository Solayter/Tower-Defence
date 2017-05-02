using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defence
{
    abstract public class Unit:Entity
    {
        
        public void Action()//Действие каждый тик
        {
            int m, n;
            bool act = false;
            if (target != null)
            {
                if (target.hp <= 0)
                {
                    Kill();
                }
                else
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
                                act = true;
                                //return;
                            }
                        }
                }
            }
            else if ((point != null)&(point.X != 0)& (point.Y != 0))
            {
                MoveToPoint();
                act = true;
            }

            if (act == false)
            {
                MoveToTarget();
            }
        }

        public void MoveToPoint() //Движение к точке
        {
            int m, n;
            for (int i = X + 1; i >= X - 1; i--)
                for (int j = Y - 1; j <= Y + 1; j++)
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
                    if (((Math.Abs(point.X - m) < Math.Abs(point.X - X)) | (Math.Abs(point.Y - n) < Math.Abs(point.Y - Y))) & (map.field[m, n].pass == true))
                    {
                        map.field[m, n].obj = this;
                        map.field[X, Y].obj = null;
                        map.field[m, n].pass = false;
                        map.field[X, Y].pass = true;
                        X = m;
                        Y = n;
                        if ((X == point.X) & (Y == point.Y))
                        {
                            point.X = 0;
                            point.Y = 0;
                        }
                        return;
                    }
                }
        }
        public void MoveToTarget() //Движение к цели
        {
            int m, n;
            if (target != null)
            {
                for (int i = X + 1; i >= X - 1; i--)
                    for (int j = Y - 1; j <= Y + 1; j++)
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
                        if (((Math.Abs(target.X - m) < Math.Abs(target.X - X)) | (Math.Abs(target.Y - n) < Math.Abs(target.Y - Y))) & (map.field[m, n].pass == true))
                        {
                            map.field[m, n].obj = this;
                            map.field[X, Y].obj = null;
                            map.field[m, n].pass = false;
                            map.field[X, Y].pass = true;
                            X = m;
                            Y = n;
                            return;
                        }
                    }
            }
        }
    }
    
    public class Melee:Unit
    {
        public Melee(bool enemy,int X, int Y)
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

    public class Range:Unit
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
