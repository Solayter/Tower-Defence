using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class BallistaCreator : UnitCreator
    {
        public override Unit Create(bool enemy, int X, int Y)
        {
            return new Ballista(enemy, X, Y);
        }
    }
}
