using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    abstract public class UnitCreator
    {
        abstract public Unit Create(bool enemy, int X, int Y);
    }

    public class MeleeCreator : UnitCreator
    {
        public override Unit Create(bool enemy,int X, int Y)
        {
            return new Melee(enemy,X,Y);
        }
    }
    public class RangeCreator : UnitCreator
    {
        public override Unit Create(bool enemy, int X, int Y)
        {
            return new Range(enemy, X, Y);
        }
    }
    public class BallistaCreator : UnitCreator
    {
        public override Unit Create(bool enemy, int X, int Y)
        {
            return new Ballista(enemy, X, Y);
        }
    }
}
