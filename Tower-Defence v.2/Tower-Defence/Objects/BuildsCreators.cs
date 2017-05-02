using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    abstract public class BuildsCreator
    {
        abstract public Building Create(bool enemy, int X, int Y);
    }
    public class TowerCreator : BuildsCreator
    {
        public override Building Create(bool enemy, int X, int Y)
        {
            return new Tower(enemy, X, Y);
        }
    }
    public class CastleCreator : BuildsCreator
    {
        public override Building Create(bool enemy, int X, int Y)
        {
            return new Castle(enemy, X, Y);
        }
    }
}
