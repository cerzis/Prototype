using Prototype.Modern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public  class Client
    {
        public Client() 
        {
            var chair = new ModernChair();
            var table = new ModernTable();
            var sofa = new ModernSofa();

            var ModernFactory = new ModernFactory(chair, table, sofa);
            
            var _chair  = ModernFactory.CreateChair();


        }

    }
}
