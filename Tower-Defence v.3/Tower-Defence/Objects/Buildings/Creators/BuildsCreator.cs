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
}
