using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tower_Defence
{
    public class Cell //Класс ячейки поля
    {
        public Entity obj { get; set; }//Может содержать в себе какой то объект
        public bool pass { get; set; }//Можно ли пройти через эту клетку
        public bool edge { get; set; }//Обозначение серых граничных клеток
        public bool flag { get; set; }//Обозначение выделенной клетки
        public int X { get; set; }
        public int Y { get; set; }

        public Cell()
        {
            pass = true;
            obj = null;
            edge = false;
            flag = false;
        }
    }
    
}
