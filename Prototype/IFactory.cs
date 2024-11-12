using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IFactory
    {

        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
}
