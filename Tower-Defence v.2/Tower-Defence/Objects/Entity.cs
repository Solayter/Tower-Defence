using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defence
{
    abstract public  class Entity //Класс всех объектов, с которыми можно взаимодействовать
    {
        public int range { get; set; }//Дальность атаки
        public int hp { get; set; } //Здоровье
        public int damage { get; set; } //Урон
        public bool enemy { get; set; }//Враг?
        public Entity target { get; set; }//Цель (Юнит/Здание)
        public int X { get; set; }//Координата в матрице по X
        public int Y { get; set; }//Координата в матрице по Y
        public bool alive { get; set; }//Жив? (для удаления с поля)
        public Map map = Map.getInstance();//Карта (в единственном экземпляре)
        public int siegeDamage { get; set; } //Осадный урон (по зданиям).
        public int attacking { get; set; }//Аттакует сейчас
        public Point point = new Point(); //Точка передвижения

        public void SearchTarget()
        {
            int m, n;
            for (int i = X - 4; i <= X + 4; i++)
            {
                for (int j = Y - 4; j <= Y + 4; j++)
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

                    if (map.field[m, n].obj != null)
                        if (map.field[m, n].obj.enemy != enemy)
                        {
                            target = map.field[m, n].obj;
                            return;
                        }
                }
            }
        }
        //public void SearchTargetForEnemy()
        //{
        //    int m, n;
        //    for (int i = X - 4; i <= X + 4; i++)
        //    {
        //        for (int j = Y - 4; j <= Y + 4; j++)
        //        {
        //            m = i;
        //            n = j;

        //            if (m < 0)
        //                m = 0;
        //            if (n < 0)
        //                n = 0;
        //            if (m > 49)
        //                m = 49;
        //            if (n > 19)
        //                n = 19;

        //            if (map.field[m, n].obj != null)
        //                if (map.field[m, n].obj.enemy == false)
        //                {
        //                    target = map.field[m, n].obj;
        //                    return;
        //                }
        //        }
        //    }
        //}

        public void Attack()
        {
            if (target != null)
            {
                if ((target is Tower) | (target is Castle))
                {
                    target.hp -= siegeDamage;
                }
                else target.hp -= damage;
                if (target.hp <= 0)
                    Kill();
            }
        }
        public void Kill()
        {
            target.alive = false;
            map.field[target.X, target.Y].obj = null;
            map.field[target.X, target.Y].pass = true;
            target = null;
        }
    }
}
