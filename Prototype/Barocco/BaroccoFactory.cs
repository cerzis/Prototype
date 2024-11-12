using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Barocco
{
    public class BaroccoFactory : IFactory
    {
        private IChair _Chair;
        private ITable _Table;
        private ISofa _Sofa;
        public BaroccoFactory(BaroccoChair Chair, BaroccoTable Table, BaroccoSofa Sofa)
        {
            _Chair = Chair;
            _Table = Table;
            _Sofa  =  Sofa;
        }
        public IChair CreateChair()
        {
            return _Chair.Clone();
        }
        public ITable CreateTable()
        {
            return _Table.Clone();
        }
        public ISofa CreateSofa()
        {
            return _Sofa.Clone();
        }

    }
}
