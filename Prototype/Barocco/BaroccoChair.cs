using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Barocco
{
    public class BaroccoChair :IChair
    {
        public IChair Clone()
        {
            return new BaroccoChair();
        }
    }
}
