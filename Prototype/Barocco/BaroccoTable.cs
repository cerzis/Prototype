using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Barocco
{
    public class BaroccoTable: ITable
    {
        public ITable Clone()
        {
            return new BaroccoTable();
        }
    }
}
