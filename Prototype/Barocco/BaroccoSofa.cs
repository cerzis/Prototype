using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Barocco
{
    public class BaroccoSofa : ISofa
    {
        public ISofa Clone()
        {
            return new BaroccoSofa();
        }
    }
}
