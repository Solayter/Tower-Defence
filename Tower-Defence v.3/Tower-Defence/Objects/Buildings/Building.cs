using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class Building:Entity
    {
        public void Action()
        {
            int m, n;
            if (target != null)
            {
                for (int i = X - range; i <= X + range; i++)
                {
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
    }
}
