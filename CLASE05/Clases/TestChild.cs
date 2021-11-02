using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE05.Clases
{
    class TestChild : Test
    {
        public TestChild(int val) : base(val)
        {
        }

        public override string ToString()
        {
            return "TestChild" + base.ToString();
        }
    }
}
