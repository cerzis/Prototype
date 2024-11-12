using Prototype.Loft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernFactory : IFactory
    {
        private IChair _Chair;
        private ITable _Table;
        private ISofa _Sofa;
        public ModernFactory(ModernChair Chair, ModernTable Table, ModernSofa Sofa)
        {
            _Chair = Chair;
            _Table = Table;
            _Sofa = Sofa;
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
