using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Defence
{
    public class CastleCreator : BuildsCreator
    {
        public override Building Create(bool enemy, int X, int Y)
        {
            return new Castle(enemy, X, Y);
        }
    }
}
