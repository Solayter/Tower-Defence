using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class MeleeCreator : UnitCreator
    {
        public override Unit Create(bool enemy, int X, int Y)
        {
            return new Melee(enemy, X, Y);
        }
    }
}
